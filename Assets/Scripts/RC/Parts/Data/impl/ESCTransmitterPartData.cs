using UnityEngine;

namespace RC.Parts.Data.impl {
    [CreateAssetMenu(fileName = "NewESCTransmitterPartData", menuName = "RC Parts/ESC Transmitter")]
    public class ESCTransmitterPartData : PartData {
        public float maxThrottle = 100f;
        public float minThrottle = 0f;
    }
}