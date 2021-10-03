using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskGroupMono : MonoBehaviour
{
    public TaskMetaDescriptionCoMono[] m_childrens;

    public void RefreshList() {
        m_childrens = GetComponentsInChildren<TaskMetaDescriptionCoMono>();
    }

    private void OnValidate()
    {
        RefreshList();   
    }
}
