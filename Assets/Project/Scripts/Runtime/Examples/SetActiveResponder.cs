using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventArchitecture.Examples
{

    public class SetActiveResponder : MonoBehaviour
    {
        [SerializeField] private GameObject _targetObject;
        [SerializeField] private bool _activeState = true;

        public void SetActiveState()
        {
            if (_targetObject == null) return;

            _targetObject.SetActive(_activeState);
        }
    }
}

