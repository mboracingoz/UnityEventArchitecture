using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EventArchitecture.Events;
using UnityEngine.Events;

namespace EventArchitecture.Listeners
{
    public sealed class VoidEventListener : MonoBehaviour
    {
        [Header("Event Configuration")]
        [SerializeField, Tooltip("The event channel this listener subscribes to.")]
        private VoidEventChannelSO _eventChannel;

        [Header("Response Configuration")]
        [SerializeField, Tooltip("Invoked when the event channel raises an event.")]
        private UnityEvent _response;

        void OnEnable()
        {
            if (_eventChannel == null) return;
            _eventChannel.RegisterListener(this);
        }

        void OnDisable()
        {
            if (_eventChannel == null) return;

            _eventChannel.UngeristerListener(this);
        }

        public void OnEventRaised()
        {
            _response?.Invoke();
        }

    }

}
