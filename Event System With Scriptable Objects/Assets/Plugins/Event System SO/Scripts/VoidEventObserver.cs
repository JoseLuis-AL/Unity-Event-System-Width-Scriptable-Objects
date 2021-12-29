using System;
using UnityEngine;
using UnityEngine.Events;

namespace Plugins.Event_System_SO.Scripts
{
    public class VoidEventObserver : MonoBehaviour
    {
        [SerializeField]
        private VoidEventSO voidEvent;

        [SerializeField]
        private UnityEvent response;

        private void OnEnable() => voidEvent.RegisterObserver(OnEventRaised);

        private void OnDisable() => voidEvent.UnregisterObserver(OnEventRaised);

        private void OnEventRaised() => response.Invoke();
    }
}
