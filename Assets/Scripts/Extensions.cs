using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public static class Extensions
{
    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = Xoshiro256SS.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    public static void Shuffle<T>(this T[] array)
    {
        int n = array.Length;
        while (n > 1)
        {
            n--;
            int k = Xoshiro256SS.Next(n + 1);
            T value = array[k];
            array[k] = array[n];
            array[n] = value;
        }
    }

    public static T Random<T>(this IList<T> list)
    {
        int index = Xoshiro256SS.Range(0, list.Count);
        return list[index];
    }

    public static float Remap(this float value, float oldMin, float oldMax, float newMin, float newMax)
    {
        return newMin + (value - oldMin) * (newMax - newMin) / (oldMax - oldMin);
    }

    public static void Show(this CanvasGroup canvasGroup, bool blockRayCasts = true, bool interactable = true)
    {
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = blockRayCasts;
        canvasGroup.interactable = interactable;
    }

    public static void Hide(this CanvasGroup canvasGroup, bool blockRayCasts = false, bool interactable = false)
    {
        canvasGroup.alpha = 0;
        canvasGroup.blocksRaycasts = blockRayCasts;
        canvasGroup.interactable = interactable;
    }

    public static Vector3 Round(this Vector3 value)
    {
        return new Vector3(Mathf.Round(value.x), Mathf.Round(value.y), Mathf.Round(value.z));
    }
}
