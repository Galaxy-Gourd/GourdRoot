namespace GGSharpData
{
    /// <summary>
    /// Defines the data passed to the client from the module after the module is initialized
    /// </summary>
    public abstract class DataModuleInitialization : Data
    {
        public IModule Module;
    }
}