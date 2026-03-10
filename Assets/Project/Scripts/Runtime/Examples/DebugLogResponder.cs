using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventArchitecture.Examples
{
    public sealed class DebugLogResponder : MonoBehaviour
    {
        [SerializeField] private string _message = "Event received!";

        public void LogMessage()
        {
            Debug.Log(_message, this);
        }
    }

}

