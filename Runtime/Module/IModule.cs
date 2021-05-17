namespace GG.Data.Base
{
    public interface IModule
    {
        /// <summary>
        /// Called on the module when client has been initialialized
        /// </summary>
        void OnModuleClientReady();
    }
}