using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{

    const int GRID_SIZE = 10;

    public int GetGridSize()
    {
        return GRID_SIZE;
    }

    public Vector2Int GetGridPosition()
    {
        return new Vector2Int(
            Mathf.RoundToInt(transform.position.x / GRID_SIZE),
            Mathf.RoundToInt(transform.position.z / GRID_SIZE)
        );
        
       
    }
}
