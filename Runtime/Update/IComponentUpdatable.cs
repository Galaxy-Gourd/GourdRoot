namespace GG.Data.Base
{
    public interface IComponentUpdatable : IComponent
    {
        #region METHODS

        /// <summary>
        /// Updates the component
        /// </summary>
        /// <param name="delta">Time (in seconds) elapsed since the previous update</param>
        void DoUpdate(float delta);

        #endregion METHODS
    }
}