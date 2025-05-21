using RC.Parts.Data.impl;
using UnityEditor;
using UnityEngine;

namespace Editor {
    [CustomEditor(typeof(MotorPartData))]
    public class MotorPartDataEditor : UnityEditor.Editor {
        public override void OnInspectorGUI() {
            var data = (MotorPartData) target;

            EditorGUILayout.LabelField("Motor Metadata", EditorStyles.boldLabel);
            data.partName = EditorGUILayout.TextField("Name", data.partName);
            data.icon = (Sprite)EditorGUILayout.ObjectField("Icon", data.icon, typeof(Sprite), false);
            data.maxCondition = EditorGUILayout.Slider("Max Condition", data.maxCondition, 0, 100);

            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Motor Specs", EditorStyles.boldLabel);
            data.maxRPM = EditorGUILayout.FloatField("Max RPM", data.maxRPM);
            data.torque = EditorGUILayout.FloatField("Torque", data.torque);

            if (GUI.changed) {
                EditorUtility.SetDirty(data);
            }
        }
    }
}