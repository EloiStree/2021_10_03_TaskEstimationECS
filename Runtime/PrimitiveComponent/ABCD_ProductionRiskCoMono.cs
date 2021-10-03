using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ABCD_ProductionRiskCoMono :MonoBehaviour{
    public ABCD_ProductionRiskComponent m_risk;
}

[System.Serializable]
public struct ABCD_ProductionRiskComponent 
{
    public ClassicABCD m_riskEstimation;
}

