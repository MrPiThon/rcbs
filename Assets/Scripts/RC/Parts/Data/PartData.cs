using UnityEngine;

namespace RC.Parts.Data {
    [CreateAssetMenu(fileName = "NewPartData", menuName = "RC Parts/Part Data", order = 0)]
    public abstract class PartData : ScriptableObject {
        public string partName;
        public float maxCondition;
        public Sprite icon;
    }
}