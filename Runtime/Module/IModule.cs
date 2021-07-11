namespace GGDataBase
{
    public interface IModule : IComponentUpdatable
    {
        #region PROPERTIES

        string ID { get; set; }
        IModuleUpdatable Updater { get; set; }
        
        #endregion PROPERTIES
        
        
        #region METHODS

        /// <summary>
        /// Destroys and cleans the module
        /// </summary>
        void Cleanup();

        /// <summary>
        /// We can assign objects to receive logs from modules for further display/output
        /// </summary>
        void SetLogListener(IModuleLogListenable listener);

        #endregion METHODS
    }
}