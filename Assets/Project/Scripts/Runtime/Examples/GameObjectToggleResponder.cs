using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EventArchitecture.Examples
{
    public sealed class GameObjectToggleResponder : MonoBehaviour
    {
        [SerializeField] private GameObject _targetObject;

        public void ToggleTarget()
        {
            if (_targetObject == null) return;

            bool isActive = _targetObject.activeSelf;
            _targetObject.SetActive(!isActive);
        }
    }

}
