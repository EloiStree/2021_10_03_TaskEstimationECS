using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(BaseClassInpsectorAutoUpdate), true), CanEditMultipleObjects]
public class BaseClassEditor : Editor
{

    public override void OnInspectorGUI()
    {

        base.OnInspectorGUI();

        var Objs = serializedObject.targetObjects;
        foreach (var Obj in Objs)
        {

            var targetValue = Obj as BaseClassInpsectorAutoUpdate;
            if (targetValue == null) continue;


            EditorApplication.delayCall += () => {
                if (targetValue.m_onlyInEditMode && Application.isPlaying)
                {
                    //Do nothing
                }
                else { 
                    targetValue.OnValidateUpdate(); 
                }
            };

        }

    }

}