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
        /// Called after the module has been installed completely
        /// </summary>
        void OnModulePostInstall();

        /// <summary>
        /// Called after all other modules have been installed
        /// </summary>
        void OnAllModulesInstalled();

        /// <summary>
        /// We can assign objects to receive logs from modules for further display/output
        /// </summary>
        void SetLogListener(IModuleLogListenable listener);

        #endregion METHODS
    }
}