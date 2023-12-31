using UnityEngine;
using UnityEngine.SceneManagement;

namespace FlappyBird
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private GameObject gameOverCanvas;
    
        void Start()
        {
            Time.timeScale = 1;
            gameOverCanvas.SetActive(false);
        }

        public void GameOver()
        {
            gameOverCanvas.SetActive(true);
            Time.timeScale = 0;
        }

        public void Replay()
        {
            SceneManager.LoadScene(0);
        }
    }
}
