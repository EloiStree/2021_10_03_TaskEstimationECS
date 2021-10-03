using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TasksMenuItems : MonoBehaviour
{

    [MenuItem("GameObject/Tasks/Create/Basic")]
    public static void CreateTaskGameObject()
    {
        Instantiate(Resources.Load("EditorPrefab/Basic Task") as GameObject);

    }
    [MenuItem("GameObject/Tasks/Set as completed", false, 0)]
    public static void Complete()
    {
        GameObject[] objs = Selection.gameObjects;
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i] != null)
            {
              //  objs[i].AddComponent<ProductionTimeEstimationComponent>();
            }

        }
        GameObject g = new GameObject("Task G");
        g.AddComponent<UpdateGameNameWithTaskInInspector>();
    }


}
