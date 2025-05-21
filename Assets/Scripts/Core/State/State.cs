namespace Core.State {
    public abstract class State {
        public virtual void OnEnter() { }
        public virtual void OnExit() { }
        public virtual void OnTick() { }
        public virtual void OnSecond() { }
    }
}