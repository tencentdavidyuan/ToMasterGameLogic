using UnityEngine;

namespace KsBattle.CombatEntities
{
    public abstract class EntityObject
    {
        /// <summary> 设置世界位置 </summary>
        /// <param name="position"></param>
        public abstract void SetWorldPosition(Vector3 position);
    }
}