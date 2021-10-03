using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public class PiLawRDCoMono : MonoBehaviour{
	public PiLawRD m_value;
}

public struct PiLawRD 
{
    [Range(0f,1f)]
    public float m_knowledgeOfCompexityAndBugInPourcent;
    [Range(0f, 1f)]
    public float m_knowledgeOfHowToImplementInPourcent;
}
