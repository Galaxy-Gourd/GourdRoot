using System;
using System.Collections.Generic;

namespace GGDataBase
{
    /// <summary>
    /// Base class for core module; ensures proper loading after creation.
    /// </summary>
    public abstract class Module<T1> : IModule
        where T1 : DataConfigModule
    {
        #region VARIABLES

        public string ID { get; set; }
        public IModuleUpdatable Updater { get; set; }
        public Action<float> OnUpdate { get; set; }

        private readonly List<string> _logCache = new List<string>();
        private IModuleLogListenable _logListener;
        private const string CONST_ModuleInitializedLogPrefix = "Module Initialized: ";
        private const string CONST_ModuleCleanupLogPrefix = "Module removed: ";
        private const string CONST_CachedLogPrefix = "[CACHED] ";

        #endregion VARIABLES
        
        
        #region CONSTRUCTION

        /// <summary>
        /// Constructs the module with the module data.
        /// </summary>
        protected Module(T1 data)
        {
            ID = data.ID;
            Log(CONST_ModuleInitializedLogPrefix + data.ID);
        }
        
        public virtual void OnModulePostInstall()
        {
            
        }

        public virtual void OnAllModulesInstalled()
        {
            
        }

        #endregion CONSTRUCTION


        #region UPDATE
        
        public virtual void DoUpdate(float delta)
        {
            OnUpdate?.Invoke(delta);
        }
        
        public virtual void Cleanup()
        {
            Log(CONST_ModuleCleanupLogPrefix + ID);
        }
        
        #endregion UPDATE


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