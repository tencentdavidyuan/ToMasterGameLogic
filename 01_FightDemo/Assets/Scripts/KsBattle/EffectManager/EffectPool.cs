using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;


namespace KsBattle.EffectManager
{
    /// <summary>
    /// 特效对象池
    /// 管理同一地址的特效实例复用，减少频繁的实例化销毁操作，提高性能
    /// </summary>
    public class EffectPool
    {
        /// <summary> 特效资源地址 </summary>
        public string Address;

        /// <summary> 可复用的空闲特效实例队列 </summary>
        public Queue<GameObject> AvailableObjects = new Queue<GameObject>();

        /// <summary> 池中管理的所有特效实体 </summary>
        public List<GameObject> AllObjects = new List<GameObject>();

        /// <summary> 是否正在异步加载资源 </summary>
        public bool IsLoading;

        public AsyncOperationHandle<GameObject> LoadHandle;
    }
}