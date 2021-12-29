using Plugins.Event_System_SO.Scripts.Base_Events;
using TMPro;
using UnityEngine;

namespace Plugins.Event_System_SO.DEMO.Scripts
{
    public class DemoUI : MonoBehaviour
    {
        // Events.
        [Header("Events (Listeners)")] [SerializeField]
        private IntEventSO intEvent;

        [SerializeField]
        private FloatEventSO floatEvent;

        [SerializeField]
        private BoolEventSO boolEvent;

        [SerializeField]
        private StringEventSO stringEvent;

        // UI Components.
        [Header("UI Text")] [SerializeField]
        private TextMeshProUGUI demoText;

        // Unity methods.
        private void OnEnable()
        {
            intEvent.AddObserver(OnIntEvent);
            floatEvent.AddObserver(OnFloatEvent);
            boolEvent.AddObserver(OnFloatEvent);
            stringEvent.AddObserver(OnStringEvent);
        }

        private void OnDisable()
        {
            intEvent.RemoveObserver(OnIntEvent);
            floatEvent.RemoveObserver(OnFloatEvent);
            boolEvent.RemoveObserver(OnFloatEvent);
            stringEvent.RemoveObserver(OnStringEvent);
        }

        // Methods.
        public void OnVoidEvent() => demoText.text = "Void Event";

        private void OnIntEvent(int value) => demoText.text = $"Int event: {value}";

        private void OnFloatEvent(float value) => demoText.text = $"Float event: {value}";

        private void OnFloatEvent(bool value) => demoText.text = $"Bool event: {value}";

        private void OnStringEvent(string value) => demoText.text = $"String event: {value}";
    }
}