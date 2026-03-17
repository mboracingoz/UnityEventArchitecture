using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventArchitecture.Examples
{
    public sealed class GameObjectToggleResponder : MonoBehaviour
    {
        [Header("Target Configuration")]
        [SerializeField, Tooltip("The GameObject whose active statel will be toggled when the event is received.")]
        private GameObject _targetObject;

        public void ToggleTarget()
        {
            if (_targetObject == null) return;

            bool isActive = _targetObject.activeSelf;
            _targetObject.SetActive(!isActive);
        }
    }

}
