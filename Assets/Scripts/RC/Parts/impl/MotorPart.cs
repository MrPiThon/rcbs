using RC.Parts.Data.impl;
using UnityEngine;

namespace RC.Parts.impl {
    public class MotorPart : RCPart {
        public MotorPartData data;
        
        private void Start() {
            if (data is not null) Debug.Log(data.partName);
        }

        public override void OnInspect() {
            base.OnInspect();
            Debug.Log($"Motor Max RPM: {data.maxRPM}");
        }
    }
}