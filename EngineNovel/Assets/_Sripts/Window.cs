using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Window : EditorWindow {

    List<List<string>> replics=new List<List<string>>();//список в списке для реплик(первый - ветки, второй-реплики)
    List<bool> act = new List<bool>();//активны ли ветке
    List<string> branch=new List<string>();

    [MenuItem("Sherman/Novel")]
    public static void ShowWindow()
    {
        GetWindow<Window>("Example");
    }

    private void OnGUI()
    {
        
        GUILayout.Label("Novel", EditorStyles.boldLabel);
        if (GUILayout.Button("+", EditorStyles.miniButtonRight))
        {
            replics.Add(new List<string>());
            //branch.Add("");
            act.Add(true);
        }
        if (GUILayout.Button("-", EditorStyles.miniButtonRight))
        {
            if (replics.Count != 0)
            {
                replics.RemoveAt(replics.Count - 1);
                act.RemoveAt(act.Count - 1);
                branch.RemoveAt(branch.Count - 1);
            }
                
        }

        for (int i = 0, j = 0; i < replics.Count; i++)
        {

            act[i] = GUILayout.Toggle(act[j], "Active is branch ");
            branch[i] = EditorGUILayout.TextField("Branch: ", branch[i]);
            if(act[j])
            {
                
                for (int k=0;j<replics[j].Count;k++)
                {
                    Debug.Log("1111");
                    EditorGUILayout.TextField("Replic", replics[i][j]);
                    Debug.Log("2222");
                }
                if(GUILayout.Button("+",EditorStyles.miniButtonRight))
                {
                    replics[j].Add("");
                }
                if (GUILayout.Button("-", EditorStyles.miniButtonRight))
                {
                    if(replics[j].Count!=0)
                        replics[j].RemoveAt(replics[j].Count-1);
                }
            }
        }
    }
}
