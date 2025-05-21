namespace Core.State.impl {
    public class WorkbenchState : State {
        public override void OnEnter() { UnityEngine.Debug.Log("Entered workbench state"); }
        public override void OnExit() { UnityEngine.Debug.Log("Exited workbench state"); }
    }
}