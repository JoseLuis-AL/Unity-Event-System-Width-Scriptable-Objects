using Plugins.Event_System_SO.Scripts;
using Plugins.Event_System_SO.Scripts.Base_Events;
using TMPro;
using UnityEngine;

namespace Plugins.Event_System_SO.DEMO.Scripts
{
    public class UIManager : MonoBehaviour
    {
        // Events.
        [Header("Events (Listeners)")] [SerializeField]
        private VoidGameEventSO voidGameEvent;

        [SerializeField]
        private IntGameEventSO intGameEvent;

        [SerializeField]
        private FloatGameEventSO floatGameEvent;

        [SerializeField]
        private BoolGameEventSO boolGameEvent;

        [SerializeField]
        private StringGameEventSO stringGameEvent;

        // UI Elements.
        [Header("UI Text")] [SerializeField]
        private TextMeshProUGUI demoText;

        // Unity methods.
        private void OnEnable()
        {
            voidGameEvent.RegisterListener(VoidMethod);
            intGameEvent.RegisterListener(IntMethod);
            floatGameEvent.RegisterListener(FloatMethod);
            boolGameEvent.RegisterListener(BoolMethod);
            stringGameEvent.RegisterListener(StringMethod);
        }

        private void OnDisable()
        {
            voidGameEvent.UnregisterListener(VoidMethod);
            intGameEvent.UnregisterListener(IntMethod);
            floatGameEvent.UnregisterListener(FloatMethod);
            boolGameEvent.UnregisterListener(BoolMethod);
            stringGameEvent.UnregisterListener(StringMethod);
        }

        // Methods.
        private void VoidMethod() => demoText.text = "Void Event";

        private void IntMethod(int value) => demoText.text = $"Int Event with value = {value}";

        private void FloatMethod(float value) => demoText.text = $"Float Event with value = {value}";

        private void BoolMethod(bool value) => demoText.text = $"Bool Event with value = {value}";

        private void StringMethod(string value) => demoText.text = $"String Event with value = {value}";
    }
}