using Cysharp.Threading.Tasks;
using Framework;



namespace KsBattle.Scene
{
    /// <summary>
    /// 战斗场景
    /// </summary>
    public class BattleScene : Disposer
    {
        
        /// <summary>
        /// 构造函数 
        /// </summary>
        public BattleScene()
        {
        }

        /// <summary>
        /// 清理
        /// </summary>
        protected override void OnDisposer()
        {
            throw new System.NotImplementedException();
        }
        
        /// <summary>
        /// 加载战斗场景
        /// </summary>
        /// <param name="battleSceneName"></param>
        /// <returns></returns>
        public async UniTask LoadSceneAsync(string battleSceneName)
        {
            await UniTask.Delay(200);
            
            // 响应场景已经准备就绪
            OnSceneReady();
        }

        /// <summary>
        /// 响应场景准备就绪
        /// </summary>
        /// <returns></returns>
        public virtual void OnSceneReady()
        {
            
        }
    }    
}
