using UnityEngine;

namespace RC.Parts.Data.impl {
    [CreateAssetMenu(fileName = "NewBatteryPartData", menuName = "RC Parts/Battery")]
    public class BatteryPartData : PartData {
        public float capacity;
        public float currentCharge;
        public float voltage;
    }
}