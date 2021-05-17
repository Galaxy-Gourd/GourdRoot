using System;
using System.Collections.Generic;

namespace GG.Data.Base
{
    /// <summary>
    /// Base class for telemetry, defined as a stream of read-only data describing the current state of a module.
    /// External classes can either subscribe to receive updates as they come, through AddListener/RemoveListener,
    /// or they can cherry-pick data whenever they want through the CurrentData property.
    /// </summary>
    public abstract class Telemetry <T,D> : ITelemetry <D> 
        where D : DataTelemetry, new()
        where T : class
    {
        #region VARIABLES

        // Properties
        public D CurrentData => _data;
        
        // Private
        protected readonly D _data = new D();
        private readonly List<Action<D>> _listeners = new List<Action<D>>();

        #endregion VARIABLES


        #region DATA

        /// <summary>
        /// Triggers the telemetry to be dispatched across all listeners
        /// </summary>
        public void Broadcast(T source)
        {
            FormatData(source);
            Dispatch();
        }
        
        /// <summary>
        /// Overriden in child classes to format the telemetry data for the specific module requirements
        /// </summary>
        protected abstract void FormatData(T module);

        /// <summary>
        /// Broadcasts the formatted telemetry data to any listeners
        /// </summary>
        private void Dispatch()
        {
            foreach (Action<D> listener in _listeners)
            {
                listener?.Invoke(_data);
            }
        }

        #endregion DATA


        #region LISTENERS

        void ITelemetry<D>.AddListener(Action<D> listener)
        {
            _listeners.Add(listener);
        }

        void ITelemetry<D>.RemoveListener(Action<D> listener)
        {
            _listeners.Remove(listener);
        }

        #endregion LISTENERS
    }
}