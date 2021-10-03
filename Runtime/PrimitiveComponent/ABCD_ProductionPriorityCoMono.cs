using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ABCD_ProductionPriorityCoMono:MonoBehaviour {
    public ABCD_ProductionPriorityComponent m_priroity;
}

[System.Serializable]
public struct ABCD_ProductionPriorityComponent 
{
    public ClassicABCD m_priorityEstimation;
}

