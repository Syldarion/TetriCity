using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceBag
{
    private Tetromino.Letter[] currentBag;
    private Tetromino.Letter[] nextBag;

    private int currentBagIndex;

    public PieceBag()
    {
        currentBag = new Tetromino.Letter[7];
        nextBag = new Tetromino.Letter[7];
        
        FillNextBag();
        SwapNextBag();
        FillNextBag();

        currentBagIndex = 0;
    }

    public Tetromino.Letter GetNextPieceLetter()
    {
        Tetromino.Letter next = currentBag[currentBagIndex];
        currentBagIndex++;

        if (currentBagIndex >= 7)
        {
            SwapNextBag();
            FillNextBag();
            currentBagIndex = 0;
        }
        
        return next;
    }

    private void SwapNextBag()
    {
        Array.Copy(nextBag, currentBag, 7);
    }

    private void FillNextBag()
    {
        nextBag = new Tetromino.Letter[7]
        {
            Tetromino.Letter.I,
            Tetromino.Letter.J,
            Tetromino.Letter.L,
            Tetromino.Letter.O,
            Tetromino.Letter.S,
            Tetromino.Letter.T,
            Tetromino.Letter.Z
        };

        nextBag.Shuffle();
    }
}
