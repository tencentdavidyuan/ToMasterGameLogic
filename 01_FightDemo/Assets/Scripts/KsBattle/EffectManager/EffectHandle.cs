using System;

namespace KsBattle.EffectManager
{
    /// <summary>
    /// 特效句柄
    /// 使用句柄模式隐藏内部实现细节，防止外部直接操作 GameObject
    /// </summary>
    public struct EffectHandle : IEquatable<EffectHandle>
    {
        /// <summary> 无效句柄常量 </summary>
        public static readonly EffectHandle Invalid = new EffectHandle(0);

        /// <summary> 特效唯一标识 Id </summary>
        public readonly ulong Id;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="id"></param>
        public EffectHandle(ulong id)
        {
            Id = id;
        }
        
        /// <summary>
        /// 相等性比较，便于在字典等集合中使用
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(EffectHandle other) => Id == other.Id;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj) => obj is EffectHandle other && Equals(other);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => Id.GetHashCode();

    }
}