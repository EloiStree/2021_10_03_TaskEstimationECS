using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskDoneProductionEstimationCoMono : MonoBehaviour
{
    public TaskDoneProductionEstimation m_timeUsedToDoTask;

}
[System.Serializable]
public struct TaskDoneProductionEstimation {
    public string m_whoWorkOnTheTask;
    public float m_timeEstimationInHour;
}