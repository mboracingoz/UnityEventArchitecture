using System.Collections;
using System.Collections.Generic;
using EventArchitecture.Events;
using UnityEditor;
using UnityEngine;

namespace EventArchitecture.Editor
{
    [CustomEditor(typeof(VoidEventChannelSO))]
    public sealed class VoidEventChannelSOEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            EditorGUILayout.Space();

            VoidEventChannelSO eventChannel = (VoidEventChannelSO)target;

            EditorGUILayout.LabelField("Runtime Info", EditorStyles.boldLabel);
            EditorGUILayout.LabelField("Current Listener Count:", eventChannel.ListenerCount.ToString());

            EditorGUILayout.Space();

            EditorGUILayout.HelpBox("Listener count is  most  useful during Play mode. Listeners register on enable and unregister on disable.",
            MessageType.Info);
        }
    }

}
