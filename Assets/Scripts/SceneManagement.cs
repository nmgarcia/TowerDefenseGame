using UnityEngine;
using UnityEngine.SceneManagement;

namespace TowerDefenseGame.Scripts
{
    public class SceneManagement : MonoBehaviour
    {
        public static SceneManagement instance;
        private void Awake()
        {
            if (instance != null)
            {
                return;
            }
            else
            {
                instance = this;
            }
        }
        public void ChangeToGameScene()
        {
            SceneManager.LoadScene("Game");
        }
        public void ChangeToMainMenuScene()
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}