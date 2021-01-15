using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityGrid : MonoBehaviour
{
    public int gridSize;

    private CityBlock[] cityBlocks;
    
    void Start()
    {
        cityBlocks = new CityBlock[gridSize * gridSize];
    }

    void Update()
    {
        
    }

    public bool BlockFree(int x, int y)
    {
        return cityBlocks[y * gridSize + x] == null;
    }

    public void AddCityBlock(int x, int y, CityBlock block)
    {
        cityBlocks[y * gridSize + x] = block;
    }
}
