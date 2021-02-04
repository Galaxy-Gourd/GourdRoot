namespace GGSharpData
{
    public interface ICoreSystemCallbacks
    {
        /// <summary>
        /// Called on the system when it has finished initialization.
        /// </summary>
        void OnPostSystemInitialized();
        
        /// <summary>
        /// Called when all of the core systems have finished initialization.
        /// </summary>
        void OnPostAllSystemsInitialized();
    }
}