using UnityEngine;
using UnityEngine.Events;

namespace Plugins.Event_System_SO.Scripts
{
    public abstract class GameEventSO<T> : ScriptableObject
    {
        private UnityEvent<T> _onRaiseEvent;

        public void Invoke(T value) => _onRaiseEvent?.Invoke(value);

        public void RegisterListener(UnityAction<T> call) => _onRaiseEvent.AddListener(call);

        public void UnregisterListener(UnityAction<T> call) => _onRaiseEvent.RemoveListener(call);
    }
}