using UnityEngine;
using System.Collections;
using UnityEditor;

[UnityEditor.CustomEditor(typeof(NPCList))]
public class CustomEditor : Editor
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