using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

[RequireComponent(typeof(TaskMetaDescriptionCoMono))]
public class UpdateGameNameWithTaskInInspector : BaseClassInpsectorAutoUpdate
{

     Component[] m_componentOnObject;
     string []m_componentTypeAsString;


    public override void OnValidateUpdate()
    {
        bool found;

        m_componentOnObject = transform.GetComponents< Component>(); 
        if ( m_componentOnObject == null || m_componentOnObject.Length == 0)
            return;
        m_componentTypeAsString = m_componentOnObject.Where(k => k != null).Select(k => k.GetType().ToString()).ToArray();
        gameObject.name = "Task";

        if(HasComponent<TaskDoneTagMono>())
            gameObject.name += ",v:";
        else gameObject.name += ":";


        TaskAliasIdCoMono alias = gameObject.GetComponent<TaskAliasIdCoMono>();
        if (alias != null && !string.IsNullOrEmpty(alias.m_alias.m_aliasId))
            gameObject.name += ":" + alias.m_alias.m_aliasId;

        TaskMetaDescriptionCoMono metaInfo = gameObject.GetComponent<TaskMetaDescriptionCoMono>();
        if (metaInfo != null && !string.IsNullOrEmpty(metaInfo.m_task.m_title))
            gameObject.name += ":" + metaInfo.m_task.m_title;

        GetFirstComponentValue<ProductionTimeEstimationCoMono>(out  found, out ProductionTimeEstimationCoMono result);
        if (found)
        {
            gameObject.name += string.Format(" ({0}-{1}-{2}> H) ", result.m_value.m_minimumHoursToDoIt
                , result.m_value.m_estimationHoursToDoIt
                , result.m_value.m_maxEstimationHoursToDoIt);
        }
        GetFirstComponentValue<ABCD_ProductionPriorityCoMono>(out found, out ABCD_ProductionPriorityCoMono prio);
        if (found)
        {
            gameObject.name += string.Format(" p{0}", prio.m_priroity.m_priorityEstimation);
        }
        GetFirstComponentValue<ABCD_ProductionRiskCoMono>(out found, out ABCD_ProductionRiskCoMono risk);
        if (found)
        {
            gameObject.name += string.Format(" r{0}", risk.m_risk.m_riskEstimation);
        }
    }

    private bool HasComponent<T>()
    {
        Type valueType = typeof(T);
        for (int i = 0; i < m_componentOnObject.Length; i++)
        {
            if (valueType!=null && m_componentTypeAsString[i] == valueType.ToString())
                return true;
        }
        return false;
    }

    public void GetFirstComponentValue<T>(out bool found, out T result) where T:Component
    {
        result = null;
        Type valueType = typeof(T);
        string valueTypeAsString = valueType.ToString();
        found = false;
        for (int i = 0; i < m_componentOnObject.Length; i++)
        {
            if (m_componentTypeAsString[i] == valueTypeAsString)
            {
                result =  m_componentOnObject[i] as T;
                found = true;
                return;
            }
        }

    }

    private bool HasAuthoringComponent(Type type)
    {
        for (int i = 0; i < m_componentOnObject.Length; i++)
        {
            if (m_componentTypeAsString[i] == type+"Authoring")
                return true;
        }
        return false;
    }
   
    public void GetFirstComponentAuthoringValue<T>( out bool found, out Component result) where T:struct {
        result = null;
        Type valueType = typeof(T);
        string valueTypeAsString = valueType.ToString();
        string valueTypeAsStringPlusAuthoring = valueTypeAsString + "Authoring";
        found = false;
        for (int i = 0; i < m_componentOnObject.Length; i++)
        {
            if (m_componentTypeAsString[i] == valueTypeAsStringPlusAuthoring) {
                result = m_componentOnObject[i];
                found = true;
                return;
            }
        }
    
    }
}
