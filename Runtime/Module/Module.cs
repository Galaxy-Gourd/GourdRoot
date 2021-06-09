using System;

namespace GG.Data.Base
{
    /// <summary>
    /// Base class for core module; ensures proper loading after creation.
    /// </summary>
    public abstract class Module<T1, T2>
        where T1 : DataConfigModule
        where T2 : DataModuleInitialization
    {
        #region VARIABLES

        private readonly Action<T2>[] _callbacks;

        #endregion VARIABLES
        
        
        #region CONSTRUCTOR

        /// <summary>
        /// Constructs the module with the module data.
        /// </summary>
        protected Module(T1 data, Action<T2>[] callbacks = null)
        {
            _callbacks = callbacks;
        }

        /// <summary>
        /// After the module has finished initializing, we may optionally inform listeners with some data
        /// </summary>
        /// <param name="initData"></param>
        protected void DispatchModuleInitializationCallbacks(T2 initData)
        {
            // We need to tell Unity-side that we're finished over here
            if (_callbacks != null)
            {
                // Send callbacks
                foreach (Action<T2> callback in _callbacks)
                {
                    callback.Invoke(initData);
                }
            }
        }

        #endregion CONSTRUCTOR
    }
}