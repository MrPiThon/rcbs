using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Core.State.impl {
    public class WorkshopState : State {
        public override void OnEnter() {
            GameManager.Instance.StartCoroutine(LoadWorkshopAsync());
        }

        private static IEnumerator LoadWorkshopAsync() {
            if (SceneManager.GetActiveScene().name == Scenes.GameScene) yield break;
            
            var loadOp = SceneManager.LoadSceneAsync(Scenes.GameScene, LoadSceneMode.Single);
            if (loadOp is null) yield break;
            
            while (!loadOp.isDone)
                yield return null;

            SceneManager.SetActiveScene(SceneManager.GetSceneByName(Scenes.GameScene));
        }

        public override void OnExit() {
            Debug.Log("Exited Workshop State");
        }
    }
}