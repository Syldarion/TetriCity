using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public static class SplitMix64
{
    private static ulong state;

    static SplitMix64()
    {
        using (RandomNumberGenerator rng = new RNGCryptoServiceProvider())
        {
            byte[] bytes = new byte[16];
            rng.GetNonZeroBytes(bytes);

            state = BitConverter.ToUInt64(bytes, 0);
        }
    }

    public static void Seed(ulong seed)
    {
        state = seed;
    }

    public static ulong Next()
    {
        ulong result = state;

        state = result + 0x9E3779B97f4A7C15;
        result = (result ^ (result >> 30)) * 0xBF58476D1CE4E5B9;
        result = (result ^ (result >> 27)) * 0x94D049BB133111EB;
        
        return result ^ (result >> 31);
    }
}

public static class Xoshiro256SS
{
    private static ulong[] state;
    
    static Xoshiro256SS()
    {
        state = new ulong[4];
        Initialize();
    }

    static void Initialize()
    {
        state[0] = SplitMix64.Next();
        state[1] = SplitMix64.Next();
        state[2] = SplitMix64.Next();
        state[3] = SplitMix64.Next();
    }

    public static void Seed(ulong seed)
    {
        SplitMix64.Seed(seed);
        Initialize();
    }

    public static ulong Next()
    {
        ulong s1x5 = state[1] * 5;
        ulong result = (s1x5 << 7) | (s1x5 >> (64 - 7));
        ulong t = state[1] << 17;

        state[2] ^= state[0];
        state[3] ^= state[1];
        state[1] ^= state[2];
        state[0] ^= state[3];

        state[2] ^= t;
        state[3] = (state[3] << 45) | (state[3] >> (64 - 45));

        return result;
    }

    public static int Next(int max)
    {
        return (int)(NextDouble() * max);
    }

    public static float Next(float max)
    {
        return (float)(NextDouble() * max);
    }

    private const double _DOUBLE_ULONG_MAX = ulong.MaxValue;
    public static double NextDouble()
    {
        return Next() / _DOUBLE_ULONG_MAX;
    }

    public static float Range(float min, float max)
    {
        return Next(max - min) + min;
    }

    public static int Range(int min, int max)
    {
        return Next(max - min) + min;
    }
}
