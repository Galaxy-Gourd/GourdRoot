namespace GG.Data.Base
{
    /// <summary>
    /// Base class for core module; ensures proper loading after creation.
    /// </summary>
    /// <typeparam name="T">DataConfigModule type</typeparam>
    public abstract class Module<T> : IModule
        where T : DataConfigModule
    {
        #region VARIABLES
        
        /// <summary>
        /// The configuration data for this module.
        /// </summary>
        protected readonly T _moduleData;

        #endregion VARIABLES


        #region CONSTRUCTOR

        /// <summary>
        /// Constructs the module with the module data.
        /// </summary>
        /// <param name="data">The module configuration data.</param>
        protected Module(T data)
        {
            _moduleData = data;
        }

        #endregion CONSTRUCTOR


        #region CALLBACKS

        public virtual void OnModuleClientReady()
        {
            
        }

        #endregion CALLBACKS
    }
}