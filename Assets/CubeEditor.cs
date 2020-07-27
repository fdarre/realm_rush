﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class CubeEditor : MonoBehaviour
{
    [SerializeField] [Range(1f,20f)] float gridSize = 10f;

    TextMesh textMesh;

    // Update is called once per frame
    void Update()
    {
        Vector3 snapPos;
        snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;
        transform.position = new Vector3(snapPos.x, 0f, snapPos.z);

        //Get component in children of type TextMesh.
        //Attention ça ne prendra pas forcement celui qu'on veut si il y en a plusieurs.
        //Ici ok car un seul composant TextMest sur tte la hierarchie
        textMesh = GetComponentInChildren<TextMesh>();
        textMesh.text = snapPos.x/10f + "," + snapPos.z/10f;


    }
}