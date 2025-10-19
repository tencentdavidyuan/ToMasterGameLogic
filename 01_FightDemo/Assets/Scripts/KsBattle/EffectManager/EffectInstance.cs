using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace KsBattle.EffectManager
{
    public class EffectInstance
    {
        /// <summary> 对外提供的句柄 </summary>
        public EffectHandle Handle;
        
        /// <summary> 特效实际的 GameObject 实例 </summary>
        public GameObject Go;
        /// <summary> 特效包含的所有粒子系统（用于播放控制和状态检测） </summary>
        public ParticleSystem[] ParticleSystems;

        /// <summary> 特效资源地址 </summary>
        public string Address;
        /// <summary> 是否为循环特效 </summary>
        public bool IsLoop;
        /// <summary> 自动回收时间配置 </summary>
        public float AutoRecycleTime;

        public Transform Parent;

        public bool FollowParent;
        public bool IsPlaying;
        public float CreateTime;

        /// <summary> 资源加载句柄 </summary>
        public AsyncOperationHandle<GameObject> LoadHandle;

        /// <summary> 自动回收计时器（实时更新） </summary>
        public float AutoRecycleTimer;
    }
}