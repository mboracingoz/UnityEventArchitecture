using System.Collections.Generic;
using UnityEngine;
using EventArchitecture.Listeners;

namespace EventArchitecture.Events
{

    [CreateAssetMenu(
    fileName = "NewVoidEventChannel",
    menuName = "Event Architecture/Events/Void Event Channel")]
    public sealed class VoidEventChannelSO : ScriptableObject
    {
        private readonly List<VoidEventListener> listeners = new();

        public int ListenerCount => listeners.Count;

        public void RegisterListener(VoidEventListener listener)
        {
            if (listener == null) return;

            if (listeners.Contains(listener)) return;

            listeners.Add(listener);
        }

        public void UngeristerListener(VoidEventListener listener)
        {
            if (listener == null) return;

            if (listeners.Count == 0) return;

            listeners.Remove(listener);
        }

        public void RaiseEvent()
        {
            if (listeners.Count == 0) return;

            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                VoidEventListener listener = listeners[i];

                if (listener == null)
                {
                    continue;
                }
                listener.OnEventRaised();
            }
        }

    }


}



