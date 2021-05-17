
using System;

namespace GG.Data.Base
{
    /// <summary>
    /// Interface for telemetry; exposed to external classes to provide access to telemetry data.
    /// </summary>
    public interface ITelemetry <out D> 
        where D : DataTelemetry, new()
    {
        #region PROPERTIES

        /// <summary>
        /// A current snapshot of the data.
        /// </summary>
        D CurrentData { get; }

        #endregion PROPERTIES
        
        
        #region METHODS
    
        /// <summary>
        /// Adds a listener to be informed whenever the telemetry data is dispatched
        /// </summary>
        void AddListener(Action<D> listener);
    
        /// <summary>
        /// Removes a listener from the dispatch queue (stops receiving telemetry data)
        /// </summary>
        void RemoveListener(Action<D> listener);
    
        #endregion METHODS
    }
}