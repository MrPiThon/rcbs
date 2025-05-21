using RC.Parts.Data.impl;
using UnityEngine;

namespace Editor {
    [UnityEditor.CustomEditor(typeof(ESCTransmitterPartData))]
    public class ESCTransmitterPartDataEditor : UnityEditor.Editor {
        public override void OnInspectorGUI() {
            var data = (ESCTransmitterPartData) target;

            UnityEditor.EditorGUILayout.LabelField("Battery Metadata", UnityEditor.EditorStyles.boldLabel);
            data.partName = UnityEditor.EditorGUILayout.TextField("Name", data.partName);
            data.icon = (Sprite)UnityEditor.EditorGUILayout.ObjectField("Icon", data.icon, typeof(Sprite), false);
            data.maxCondition = UnityEditor.EditorGUILayout.Slider("Max Condition", data.maxCondition, 0, 100);

            UnityEditor.EditorGUILayout.Space();
            UnityEditor.EditorGUILayout.LabelField("Battery Specs", UnityEditor.EditorStyles.boldLabel);
            data.maxThrottle = UnityEditor.EditorGUILayout.FloatField("Max Throttle", data.maxThrottle);
            data.minThrottle = UnityEditor.EditorGUILayout.FloatField("Min Throttle", data.minThrottle);

            if (GUI.changed) {
                UnityEditor.EditorUtility.SetDirty(data);
            }
        }
    }
}