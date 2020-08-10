using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
[RequireComponent(typeof(Waypoint))]
public class CubeEditor : MonoBehaviour
{
    Waypoint waypoint;

    private void Awake()
    {
        waypoint = GetComponent<Waypoint>();
    }

    void Update()
    {
        SnapToGrid();
        UpdateLabel();
    }

    private void SnapToGrid()
    {
        int gridSize = waypoint.GetGridSize();
        transform.position = new Vector3(
            waypoint.GetGridPosition().x,
            0f,
            //y coordinate correspond to the z coordinate in the world
            waypoint.GetGridPosition().y 
        );
    }

    private void UpdateLabel()
    {
        int gridSize = waypoint.GetGridSize();
        TextMesh textMesh = GetComponentInChildren<TextMesh>();
        string labelText =
            waypoint.GetGridPosition().x / gridSize +
            "," +
            //y coordinate correspond to the z coordinate in the world
            waypoint.GetGridPosition().y / gridSize; 
        textMesh.text = labelText;
        gameObject.name = labelText;
    }
}
