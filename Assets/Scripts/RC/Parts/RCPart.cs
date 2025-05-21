using UnityEngine;

namespace RC.Parts {
    public abstract class RCPart : MonoBehaviour {
        public string PartName;
        [Range(0, 100)] public float Condition = 100f;
        public bool Attached { get; private set; } = false;

        public virtual void Attach() {
            Attached = true;
            Debug.Log($"{PartName} attached.");
        }

        public virtual void Detach() {
            Attached = false;
            Debug.Log($"{PartName} detached.");
        }

        public virtual void OnSelect() {
            Debug.Log($"{PartName} selected.");
        }

        public virtual void OnDeselect() {
            Debug.Log($"{PartName} deselected.");
        }

        public virtual void OnInspect() {
            Debug.Log($"{PartName} inspected.");
        }
    }
}