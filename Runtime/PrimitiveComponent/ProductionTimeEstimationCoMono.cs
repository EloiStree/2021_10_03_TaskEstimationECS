using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class ProductionTimeEstimationCoMono : MonoBehaviour {
    public ProductionTimeEstimationComponent m_value;
}

[System.Serializable]
public struct ProductionTimeEstimationComponent 
{
    public float m_minimumHoursToDoIt;
    public float m_estimationHoursToDoIt;
    public float m_maxEstimationHoursToDoIt;
}
