//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PushToTaskManagerInSceneAtEntityConversion : MonoBehaviour, IConvertGameObjectToEntity
//{
//    public TaskEntityLinkIdMono m_idToUse;
//    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
//    {
//        if (m_idToUse == null)
//            return;
//        Debug.Log("Test add entity Task Id link:" + m_idToUse.GetTaskId());
//    }

//    void Reset() {
//        if (this.GetComponent<TaskEntityLinkIdMono>() == null)
//            this.gameObject.AddComponent<TaskEntityLinkIdDefaultMono>();
//        m_idToUse = this.GetComponent<TaskEntityLinkIdMono>();
//    }
//}
