using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Window : EditorWindow {

    public string branch = "main";

    List<string> replics=new List<string>();
    List<bool> act = new List<bool>();

    [MenuItem("Sherman/Novel")]
    public static void ShowWindow()
    {
        GetWindow<Window>("Example");
    }

    private void OnGUI()
    {
        act.Add(true);
        GUILayout.Label("Novel", EditorStyles.boldLabel);

        for (int i = 0, j = 0; i < replics.Count; i++)
        { 
            act[j] = GUILayout.Toggle(act[j], "Active");
            branch = EditorGUILayout.TextField("Branch: ", branch);
            if(act[j])
            { 
                for (;i<replics.Count;j++)
                {         
                    EditorGUILayout.TextField("Replic", replics[i]);
                }
                if(GUILayout.Button("+",EditorStyles.miniButtonRight))
                {
                    replics.Add("");
                }
                if (GUILayout.Button("-", EditorStyles.miniButtonRight))
                {
                    if(replics.Count!=0)
                        replics.RemoveAt(replics.Count-1);
                }
            }
        }
    }
}
