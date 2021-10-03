using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskEntityLinkIdDefaultMono : TaskEntityLinkIdMono
{
    public string m_dateAsStringWhenCreated;

    public override ulong GetTaskId()
    {
        m_dateAsStringWhenCreated = DateTime.Now.ToString("yyyy MM dd HH mm ss ffff"); 
        return ulong.Parse(m_dateAsStringWhenCreated.Replace(" ", ""));
         
    }

}

public abstract class TaskEntityLinkIdMono : MonoBehaviour
{
    public ulong m_gameObjectId;
    public abstract ulong GetTaskId();

    private void Reset()
    {

        m_gameObjectId = GetTaskId();
    }
}





