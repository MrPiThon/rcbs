using Core.State.impl;
using UnityEngine;

namespace Core {
    public class GameManager : MonoBehaviour {
        public static GameManager Instance { get; private set; }
        public State.State CurrentState { get; private set; } = new MenuState();
        
        private void Awake() {
            if (Instance is not null && Instance != this) {
                Destroy(gameObject);
                return;
            }

            CurrentState.OnEnter();
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        public void ChangeToWorkshopState() {
            CurrentState.OnExit();
            CurrentState = new WorkshopState();
            CurrentState.OnEnter();
        }
        
        public void ChangeState(State.State newState) {
            if (newState == null) return;
            
            if (CurrentState == null) {
                CurrentState = newState;
                CurrentState.OnEnter();
                return;
            }
            
            CurrentState.OnExit();
            CurrentState = newState;
            CurrentState.OnEnter();
        }
    }
}