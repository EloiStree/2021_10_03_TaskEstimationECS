using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class TaskAliasIdCoMono : MonoBehaviour 
{
    public TaskAliasIDComponent m_alias;
}

[System.Serializable]
public struct TaskAliasIDComponent 
{
    public string m_aliasId;
}
