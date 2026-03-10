using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EventArchitecture.Events;

namespace EventArchitecture.Examples
{
    public sealed class VoidEventInvoker : MonoBehaviour
    {
        [SerializeField] private VoidEventChannelSO _eventChannel;

        public void RaiseEvent()
        {
            if (_eventChannel == null) return;
            _eventChannel.RaiseEvent();
        }

    }

}
