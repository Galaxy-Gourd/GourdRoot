namespace GGSharpData
{
    public interface IModule
    {
        /// <summary>
        /// Called on the module when client has been initialialized
        /// </summary>
        void OnModuleClientReady();
    }
}