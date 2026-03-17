using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventArchitecture.Examples
{

    public class SetActiveResponder : MonoBehaviour
    {
        [Header("Target Configuration")]
        [SerializeField, Tooltip("The GameObject that will receive the active state change.")]
        private GameObject _targetObject;

        [Header("Active State Configuration")]
        [SerializeField, Tooltip("The active state that will be set on the target GameObject.")]
        private bool _activeState = true;

        public void SetActiveState()
        {
            if (_targetObject == null) return;

            _targetObject.SetActive(_activeState);
        }
    }
}

