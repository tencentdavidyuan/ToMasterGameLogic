using Framework;
using KsBattle.BattleMgr.Core;



namespace KsBattle
{
    /// <summary>
    /// 销毁战斗系统
    /// </summary>
    public class KsBattleSystem : Disposer
    {
        /// <summary> 是否已初始化 </summary>
        private static bool _initialized = false;
        /// <summary> KsBattle 系统 </summary>
        private static KsBattleSystem _ksBattleSystem;
        /// <summary> KSBattle 实例化器 </summary>
        private static KsBattleSystem Instance => _ksBattleSystem ??= new KsBattleSystem();

        
        /// <summary> 战斗管理器 </summary>
        private BattleManager _battleManager;

        /// <summary>
        /// 构造函数
        /// </summary>
        private KsBattleSystem()
        {
        }
        
        /// <summary>
        /// 清理
        /// </summary>
        protected override void OnDisposer()
        {
            DestroyBattleManager();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns></returns>
        public bool Initialize()
        {
            if (_initialized)
                return true;

            if (!CreateBattleManager())
            {
                
                return false;
            }

            return true;
        }

        #region 战斗管理器

        /// <summary>
        /// 创建战斗
        /// </summary>
        /// <returns></returns>
        private bool CreateBattleManager()
        {
            _battleManager ??= new BattleManager();
            return _battleManager != null;
        }

        /// <summary>
        /// 销毁战斗
        /// </summary>
        private void DestroyBattleManager()
        {
            _battleManager?.Dispose();
            _battleManager = null;
        }

        #endregion
    }
}