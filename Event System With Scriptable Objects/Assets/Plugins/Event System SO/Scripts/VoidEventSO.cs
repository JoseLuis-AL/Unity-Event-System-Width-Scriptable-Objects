using UnityEngine;
using UnityEngine.Events;

namespace Plugins.Event_System_SO.Scripts
{
    [CreateAssetMenu(menuName = "Events SO/Void Event")]
    public class VoidEventSO : ScriptableObject
    {
        private readonly UnityEvent _onRaiseEvent = new UnityEvent();
        
        public void Invoke() => _onRaiseEvent?.Invoke();

        public void RegisterObserver(UnityAction call) => _onRaiseEvent.AddListener(call);

        public void UnregisterObserver(UnityAction call) => _onRaiseEvent.RemoveListener(call);
    }
}
