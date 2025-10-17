using KsBattle.CombatEntities;
using UnityEngine;

namespace KsBattle.CombatObjects
{
    public abstract class CombatObject
    {
        /// <summary> 数据对象的动态 Id </summary>
        public ulong DynamicId { get; private set; }

        /// <summary> 世界位置 </summary>
        public Vector3 WorldPosition { get; private set; }
        /// <summary> 世界朝向 </summary>
        public Vector3 WorldForward { get; private set; }
        /// <summary> 世界空间下的缩放 </summary>
        public Vector3 WorldScale { get; private set; }
        /// <summary> 世界空间下的旋转 </summary>
        public Quaternion WorldRotation { get; private set; }

        /// <summary> 实体对象 </summary>
        public EntityObject EntityObject { get; private set; }


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="dynamicId"></param>
        /// <param name="worldPosition"></param>
        /// <param name="worldForward"></param>
        /// <param name="worldScale"></param>
        protected CombatObject(ulong dynamicId, Vector3 worldPosition, Vector3 worldForward, Vector3 worldScale)
        {
            
        }
        
        protected void SetWorldPosition(Vector3 position)
        {
            WorldPosition = position;
            EntityObject?.SetWorldPosition(position);
        } 
    }
}