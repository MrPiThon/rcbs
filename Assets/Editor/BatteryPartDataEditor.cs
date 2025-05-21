using RC.Parts.Data.impl;
using UnityEditor;
using UnityEngine;

namespace Editor {
    [CustomEditor(typeof(BatteryPartData))]
    public class BatteryPartDataEditor : UnityEditor.Editor {
        public override void OnInspectorGUI() {
            var data = (BatteryPartData) target;

            EditorGUILayout.LabelField("Battery Metadata", EditorStyles.boldLabel);
            data.partName = EditorGUILayout.TextField("Name", data.partName);
            data.icon = (Sprite)EditorGUILayout.ObjectField("Icon", data.icon, typeof(Sprite), false);
            data.maxCondition = EditorGUILayout.Slider("Max Condition", data.maxCondition, 0, 100);

            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Battery Specs", EditorStyles.boldLabel);
            data.voltage = EditorGUILayout.FloatField("Voltage (V)", data.voltage);
            data.capacity = EditorGUILayout.FloatField("Capacity (mAh)", data.capacity);
            data.currentCharge = EditorGUILayout.Slider("Current Charge", data.currentCharge, 0, 1);

            if (GUI.changed) {
                EditorUtility.SetDirty(data);
            }
        }
    }
}