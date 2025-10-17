using Framework;
using KsBattle.BattleData;

namespace KsBattle
{
    public class KsBattleSystem : Disposer
    {
        /// <summary> KsBattle 系统 </summary>
        private static KsBattleSystem _ksBattleSystem;
        /// <summary> KSBattle 实例化器 </summary>
        private static KsBattleSystem Instance => _ksBattleSystem ??= new KsBattleSystem();


        public BattleDataManager BattleDataMgr { get; private set; }


        private KsBattleSystem()
        {
        }
        
        /// <summary>
        /// 清理
        /// </summary>
        protected override void OnDisposer()
        {
            
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <returns></returns>
        private bool Initialize()
        {
            return false;
        }

        private void Destroy()
        {
            
        }

        private bool CreateBattleDataManager()
        {
            BattleDataMgr ??= new BattleDataManager();
            return BattleDataMgr != null;
        }

        private void DestroyBattleDataManager()
        {
            BattleDataMgr = null;
        }


    }
}