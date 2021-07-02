namespace GGDataBase
{
    public interface IModuleLogListenable
    {
        #region METHODS

        /// <summary>
        /// Called on a listener whenever a module throws a new log.
        /// </summary>
        void OnModuleLog(string message);

        #endregion METHODS
    }
}