using UnityEngine;

namespace RC.Parts.impl {
    public class ESCTransmitter : RCPart {
        public float throttle;
        public float maxThrottle = 100f;
        public float minThrottle = 0f;

        public override void OnInspect() {
            base.OnInspect();
            Debug.Log($"Throttle: {throttle}");
        }
    }
}