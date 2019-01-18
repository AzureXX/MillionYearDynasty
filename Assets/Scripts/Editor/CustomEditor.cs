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
        if (GUILayout.Button("New Day"))
        {
            if (Application.isPlaying)
            {
                script.MakeAllNPCActions();
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

        if (GUILayout.Button("Generate Initial Sector"))
        {
            if (Application.isPlaying)
            {
                script.GenerateInitialSector();
            }
        }
        if (GUILayout.Button("Get All Child Chunks"))
        {
            if (Application.isPlaying)
            {
                script.GetAllChunks();
            }
        }

    }

}

