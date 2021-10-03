using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitCommitUsedForTaskManagerMono : MonoBehaviour
{
    public GitCommitDirectLink m_versionOfTaskManager;
    public GameObject m_toAffect;
    [ContextMenu("Open git server")]
    public void OpenGitUrl()
    {
        Application.OpenURL(m_versionOfTaskManager.m_gitUrl);
    }
    [ContextMenu("Open git at Commit")]
    public void OpenGitUrlAtCommitLocation()
    {
        Application.OpenURL(GetGitAndCommitLink());
    }

    private string GetGitAndCommitLink()
    {
        return m_versionOfTaskManager.m_gitUrl + "#" + m_versionOfTaskManager.m_gitCommitId;
    }

    private void OnValidate()
    {
        m_toAffect.name = "Task Estimator Version: " + GetGitAndCommitLink();
    }
    private void Reset()
    {
        m_toAffect = this.gameObject;
    }
}
[System.Serializable]
public struct GitCommitDirectLink {
    public string m_gitUrl;
    public string m_gitCommitId;
}
