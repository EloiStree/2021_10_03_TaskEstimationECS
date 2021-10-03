
using UnityEngine;

public abstract class BaseClassInpsectorAutoUpdate : MonoBehaviour
{
    //[HideInInspector] public bool NeedsAutoUpdate;
    //protected void OnValidate() { NeedsAutoUpdate = !Application.isPlaying; }
    //public virtual void AutoUpdate() { NeedsAutoUpdate = false; 
    //    OnValidateUpdate(); }
    public bool m_onlyInEditMode=true;
    public abstract void OnValidateUpdate();
}
