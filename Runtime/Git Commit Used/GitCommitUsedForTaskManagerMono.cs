using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitCommitUsedForTaskManagerMono : MonoBehaviour
{
    public GitCommitDirectLink m_versionOfTaskManager;

    [ContextMenu("Open git server")]
    public void OpenGitUrl()
    {
        Application.OpenURL(m_versionOfTaskManager.m_gitUrl);
    }
    [ContextMenu("Open git at Commit")]
    public void OpenGitUrlAtCommitLocation()
    {
        Application.OpenURL(m_versionOfTaskManager.m_gitUrl+"#"+m_versionOfTaskManager.m_gitCommitId);
    }
}
[System.Serializable]
public struct GitCommitDirectLink {
    public string m_gitUrl;
    public string m_gitCommitId;
}