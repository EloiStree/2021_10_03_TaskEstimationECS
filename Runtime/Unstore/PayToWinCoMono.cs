using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayToWinCoMono : MonoBehaviour
{
    [TextArea(0,5)]
    public string m_descriptionOfWhatCanBeBoughtToSkipWorks;
    public float m_minEstimationCost;
    public float m_maxEstimationCost;
    public PayUnityType m_unitType;
}
public enum PayUnityType { Local , Dollar, Euro, Undefined}// Yeah feel free to ask me to add some