using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PossibleComplicationCoMono : MonoBehaviour
{
    public PossibleComplication m_complication;
}

[System.Serializable]
public struct PossibleComplication
{
    public string m_inShort;
    public string m_details;
}
