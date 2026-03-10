using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EventArchitecture.Events;
using UnityEngine.Events;

namespace EventArchitecture.Listeners
{
    public sealed class VoidEventListener : MonoBehaviour
    {
        [SerializeField] private VoidEventChannelSO _eventChannel;
        [SerializeField] private UnityEvent _response;

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
