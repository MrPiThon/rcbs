using UnityEngine;

namespace RC.Parts.impl {
    public class BatteryPart : RCPart {
        public float Charge = 100f;

        public override void OnInspect() {
            base.OnInspect();
            Debug.Log($"Battery Charge: {Charge}%");
        }
    }
}