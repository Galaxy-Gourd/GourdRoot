namespace GGSharpData
{
    public interface IModuleCallbacks
    {
        /// <summary>
        /// Called on the module when it has finished initialization.
        /// </summary>
        void OnPostModuleInitialized();
    }
}