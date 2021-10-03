using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TaskMetaDescriptionCoMono: MonoBehaviour
{
    public TaskMetaDescription m_task;
}

[System.Serializable]
public struct TaskMetaDescription
{
    public string m_title;
    public string m_shortDescription;
    [TextArea(4, 10)]
    public string m_longDescription;
}
