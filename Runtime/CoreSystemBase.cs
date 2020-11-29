namespace GGSharpData
{
    /// <summary>
    /// Base class for core systems; ensures proper loading after creation.
    /// </summary>
    /// <typeparam name="T">CoreSystemData type</typeparam>
    /// <typeparam name="C">ICoreSystemClient type</typeparam>
    public class CoreSystemBase <T, C> : ICoreSystemCallbacks where C : ICoreSystemClient
    {
        #region Variables

        /// <summary>
        /// The configuration data for this system.
        /// </summary>
        protected readonly T _systemData;
        
        /// <summary>
        /// The configuration data for this system.
        /// </summary>
        protected readonly C _systemClient;

        #endregion Variables


        #region Constructor

        /// <summary>
        /// Constructs the system with the system data.
        /// </summary>
        /// <param name="data">The system configuration data.</param>
        /// <param name="client">The system client receiving the initialization complete callback.</param>
        protected CoreSystemBase(T data, C client)
        {
            _systemData = data;
            _systemClient = client;
        }

        #endregion Constructor


        #region Callbacks

        public virtual void OnPostCoreSystemsInitialization()
        {
            
        }

        #endregion Callbacks
    }
}