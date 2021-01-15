using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class Tetromino : MonoBehaviour
{
    public enum Letter
    {
        I,
        J,
        L,
        O,
        S,
        T,
        Z
    }

    public Letter tetrominoLetter;
    public List<CityBlock> tetrominoBlocks;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
