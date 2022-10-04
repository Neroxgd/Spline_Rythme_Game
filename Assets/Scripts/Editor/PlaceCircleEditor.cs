using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using System;


[CustomEditor(typeof(PlaceCircles))]

public class PlaceCircleEditor : Editor
{

    public override void OnInspectorGUI()
    {
         DrawDefaultInspector();

         if (GUILayout.Button("Place Circles"))
        {
            PlaceCircles placeCircles = target as PlaceCircles;
            placeCircles.PlaceCircleOnScene();

        }


    }





}
