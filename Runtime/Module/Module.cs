namespace GGSharpData
{
    /// <summary>
    /// Base class for core module; ensures proper loading after creation.
    /// </summary>
    /// <typeparam name="T">DataConfigModule type</typeparam>
    public abstract class Module <T> : IModule, IModuleCallbacks 
        where T : DataConfigModule
    {
        #region Variables
        
        /// <summary>
        /// The configuration data for this module.
        /// </summary>
        protected readonly T _moduleData;

        #endregion Variables


        #region Constructor

        /// <summary>
        /// Constructs the module with the module data.
        /// </summary>
        /// <param name="data">The module configuration data.</param>
        protected Module(T data)
        {
            _moduleData = data;
        }

        #endregion Constructor


        #region Callbacks

        public virtual void OnPostModuleInitialized()
        {
            
        }

        #endregion Callbacks

    }
}