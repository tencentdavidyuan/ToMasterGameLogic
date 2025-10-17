using System;

namespace Framework
{
    public abstract class Disposer : IDisposable
    {
        private bool _dispose;

        protected abstract void OnDisposer();
        
        public void Dispose()
        {
            if (_dispose)
                return;
            
            OnDisposer();
        }
    }
}