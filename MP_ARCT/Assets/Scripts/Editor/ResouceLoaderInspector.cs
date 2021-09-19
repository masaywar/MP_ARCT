using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ResourceLoader), true)]
public class DatabaseLoaderInspector : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        ResourceLoader dbLoader = (ResourceLoader)target;
        if (GUILayout.Button("Load Resources"))
            dbLoader.LoadResources();
    }
}
