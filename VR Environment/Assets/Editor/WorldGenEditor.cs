using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(WorldGen))]
public class LevelScriptEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        WorldGen myTarget = (WorldGen)target;

        if (GUILayout.Button("Generate Chunks"))
        {
            myTarget.Gen();
        }

        if (GUILayout.Button("Delete Chunks"))
        {
            myTarget.Delete();
        }
    }
}