using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventArchitecture.Examples
{
    public sealed class DebugLogResponder : MonoBehaviour
    {
        [Header("Debug Output Configuration")]
        [SerializeField, Tooltip("The message written to the Console when the event is received.")]
        private string _message = "Event received!";

        public void LogMessage()
        {
            Debug.Log(_message, this);
        }
    }

}

