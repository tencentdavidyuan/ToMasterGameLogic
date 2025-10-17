using UnityEngine;

namespace KsBattle.CombatEntities
{
    public class EntityGo : EntityObject
    {
        /// <summary> Unity GameObject 对象 </summary>
        protected GameObject Go { get; private set; }
        

        #region EntityObject 虚函数

        /// <summary>
        /// 设置世界位置
        /// </summary>
        /// <param name="position"></param>
        public override void SetWorldPosition(Vector3 position)
        {
            if (Go)
            {
                Go.transform.position = position;
            }
        }

        #endregion

    }
}