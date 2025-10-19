using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Framework;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;


namespace KsBattle.EffectManager
{
    /// <summary>
    /// 特效管理器
    /// </summary>
    public class EffectMgr : Disposer
    {
        /// <summary> 活跃特效字典 </summary>
        private readonly Dictionary<ulong, EffectInstance> _activeEffects = new ();
        /// <summary> 特效对象池字典[资源地址 - 对象池] </summary>
        private readonly Dictionary<string, EffectPool> _effectPools = new();

        /// <summary> 待回收特性 ID 列表（用于帧更新中的批量回收） </summary>
        private readonly List<ulong> _effectsToRecycle = new List<ulong>();
        
        /// <summary>
        /// 特效管理器
        /// </summary>
        public EffectMgr()
        {
            
        }
        
        /// <summary>
        /// 清理
        /// </summary>
        protected override void OnDisposer()
        {
            
        }

        /// <summary>
        /// 获取或创建特效对象池
        /// 如果池不存在则异步加载资源并创建新池
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        private async UniTask<EffectPool> GetOrCreateEffectPool(string address)
        {
            if (_effectPools.TryGetValue(address, out var pool))
                return pool;

            pool = new EffectPool() { Address = address };
            _effectPools[address] = pool;

            try
            {
                pool.IsLoading = true;
                pool.LoadHandle = Addressables.LoadAssetAsync<GameObject>(address);
                await pool.LoadHandle.Task;

                if (pool.LoadHandle.Status != AsyncOperationStatus.Succeeded)
                {
                    _effectPools.Remove(address);
                    return null;
                }

                return pool;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
    }
}