using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(NPCList))]
public class EditorAddNPC : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var script = (NPCList)target;

        if (GUILayout.Button("Add NPC"))
        {
            if (Application.isPlaying)
            {
                script.AddNPC();
            }
        }

    }

}

[CustomEditor(typeof(MapState))]
public class EditorMapState : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        var script = (MapState)target;

        if (GUILayout.Button("GenerateInitialSector"))
        {
            if (Application.isPlaying)
            {
                script.GenerateInitialSector();
            }
        }

    }

}