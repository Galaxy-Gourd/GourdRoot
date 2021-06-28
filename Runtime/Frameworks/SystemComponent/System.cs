using System.Collections.Generic;

namespace GGDataBase
{
    /// <summary>
    /// Base definition for a system; a system is defined as a class that holds references to components, over
    /// which it iterates and performs some functionality.
    /// </summary>
    /// <typeparam name="T">The component type for this system.</typeparam>
    public abstract class System<T> where T : IComponent
    {
        #region VARIABLES

        public List<T> Components => _components;
        
        /// <summary>
        /// The list of currently registered components for this system.
        /// </summary>
        protected readonly List<T> _components = new List<T>();

        #endregion VARIABLES
        
        
        #region REGISTRATION

        public void AddComponent(T component)
        {
            _components.Add(component);
        }
        
        public void RemoveComponent(T component)
        {
            _components.Remove(component);
        }

        #endregion REGISTRATION
    }
}