using System;
using System.Collections.Generic;

namespace GGDataBase
{
    /// <summary>
    /// Base class for core module; ensures proper loading after creation.
    /// </summary>
    public abstract class Module<T1, T2> : IModule
        where T1 : DataConfigModule
        where T2 : DataModuleInitialization
    {
        #region VARIABLES

        public string ID { get; set; }
        public IModuleUpdatable Updater { get; set; }

        private readonly Action<T2>[] _callbacks;
        private readonly List<string> _logCache = new List<string>();
        private IModuleLogListenable _logListener;
        private const string CONST_ModuleInitializedLogPrefix = "Module Initialized: ";
        private const string CONST_CachedLogPrefix = "[CACHED] ";

        #endregion VARIABLES
        
        
        #region CONSTRUCTION

        /// <summary>
        /// Constructs the module with the module data.
        /// </summary>
        protected Module(T1 data, Action<T2>[] callbacks = null)
        {
            _callbacks = callbacks;
            ID = data.ID;
            Log(CONST_ModuleInitializedLogPrefix + data.ID);
        }

        public virtual void OnModulePostInstall()
        {
            
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

        #endregion CONSTRUCTION


        #region UPDATE
        
        public virtual void DoUpdate(float delta)
        {

        }
        
        #endregion UPDATE


        #region CLEANUP

        public virtual void Cleanup()
        {
            
        }

        #endregion CLEANUP


        #region DEBUG

        protected void Log(string message)
        {
            if (_logListener == null)
            {
                _logCache.Add(message);
                return;
            }
            
            _logListener.OnModuleLog(message);
        }
        
        void IModule.SetLogListener(IModuleLogListenable listener)
        {
            _logListener = listener;
            foreach (string log in _logCache)
            {
                _logListener.OnModuleLog(CONST_CachedLogPrefix + log);
            }
        }

        #endregion DEBUG
    }
}