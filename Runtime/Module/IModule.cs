namespace GG.Data.Base
{
    public interface IModule
    {
        #region PROPERTIES

        string ID { get; set; }

        #endregion PROPERTIES
        
        
        #region METHODS

        /// <summary>
        /// Ticks the module; implement with specific funtionality, or ignore if not applicable
        /// </summary>
        /// <param name="delta">Time (seconds) since previous tick</param>
        void Tick(float delta);

        /// <summary>
        /// Destroys and cleans the module
        /// </summary>
        void Cleanup();

        #endregion METHODS
    }
}