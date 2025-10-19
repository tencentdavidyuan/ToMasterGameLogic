using System.Collections.Generic;
using Framework;



namespace KsBattle.BattleMgr.Core
{
    /// <summary>
    /// 战斗管理器
    /// </summary>
    public class BattleManager : Disposer
    {
        /// <summary> 战斗的动态 Id </summary>
        private uint _battleDynamicId;
        /// <summary> 所有战斗 </summary>
        private Dictionary<uint, BattleBase> _allBattles = new Dictionary<uint, BattleBase>();
        
        /// <summary>
        /// 
        /// </summary>
        public BattleManager()
        {
            
        }

        /// <summary>
        /// 清理
        /// </summary>
        protected override void OnDisposer()
        {
            // 释放所有战斗
        }
        
        
        
        
    }
}

