using UnityEngine;

namespace RC.Parts.Data.impl {
    [CreateAssetMenu(fileName = "NewMotorPartData", menuName = "RC Parts/Motor")]
    public class MotorPartData : PartData {
        public float maxRPM;
        public float torque;
    }
}