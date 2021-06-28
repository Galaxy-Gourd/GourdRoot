namespace GG.Data.Base
{
    public interface IModule : IComponentUpdatable
    {
        #region PROPERTIES

        string ID { get; set; }

        #endregion PROPERTIES
        
        
        #region METHODS

        /// <summary>
        /// Destroys and cleans the module
        /// </summary>
        void Cleanup();

        #endregion METHODS
    }
}