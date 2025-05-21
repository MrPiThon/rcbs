namespace Core.State.impl {
    public class MenuState : State {
        public override void OnEnter() { UnityEngine.Debug.Log("Entered menu state"); }
        public override void OnExit() { UnityEngine.Debug.Log("Exited menu state"); }
    }
}