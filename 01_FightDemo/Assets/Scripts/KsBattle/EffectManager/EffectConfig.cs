using UnityEngine;

namespace KsBattle.EffectManager
{
    /// <summary>
    /// 特效配置
    /// </summary>
    public struct EffectConfig
    {
        /// <summary> 特效地址 </summary>
        public string Address;
        /// <summary> 是否循环播放 </summary>
        public bool IsLoop;
        /// <summary> 自动回收时间（非循环特效有效，小于等于 0 标识不自动回收 </summary>
        public float AutoRecycleTime;

        /// <summary> 初始位置 </summary>
        public Vector3 Position;
        /// <summary> 初始旋转 </summary>
        public Quaternion Rotation;
        /// <summary> 初始缩放 </summary>
        public Vector3 Scale;
        /// <summary> 父节点 Transform, 用于层级管理 </summary>
        public Transform Parent;

        /// <summary> 是否跟随父节点（适用于附着在角色身上的特效） </summary>
        public bool FollowParent;

        /// <summary>
        /// 获得默认配置的快捷方式
        /// </summary>
        public static EffectConfig Default => new EffectConfig()
        {
            Position = Vector3.zero,
            Rotation = Quaternion.identity,
            
            // 默认不自动回收
            AutoRecycleTime = -1f
        };
    }
}