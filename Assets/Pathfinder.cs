using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{

    Dictionary<Vector2Int, Waypoint> grid = new Dictionary<Vector2Int, Waypoint>();
    [SerializeField] Waypoint startWaypoint;
    [SerializeField] Waypoint endWaypoint;

    // Start is called before the first frame update
    void Start()
    {
        LoadBlocks();
        ColorStartAndEnd();
    }

    private void LoadBlocks()
    {
        //return every GameObject with a waypoint script attached
        var waypoints = FindObjectsOfType<Waypoint>();

        foreach (Waypoint waypoint in waypoints)
        {
            var gridPos = waypoint.GetGridPosition();

            if (grid.ContainsKey(gridPos))
            {
                print("Skipping overlapping block");
            }
            else
            {
                grid.Add(gridPos, waypoint);
            }
        }
    }

    private void ColorStartAndEnd()
    {
        startWaypoint.SetTopColor(Color.red);
        endWaypoint.SetTopColor(Color.blue);
    }

}
