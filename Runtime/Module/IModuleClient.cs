using System;

namespace GGSharpData
{
    public interface IModuleClient
    {
        #region METHODS

        /// <summary>
        /// Called on the client from the module after the module has finished initializing itself
        /// </summary>
        /// <param name="data"></param>
        void OnModuleInitialized(DataModuleInitialization data);

        #endregion METHODS
    }
}