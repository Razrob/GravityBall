using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

namespace GravityBall
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private Text scoreText;
        [SerializeField] public GameObject pauseMenuWindow;
        [SerializeField] public GameObject GameOverMenuWindow;
        [SerializeField] public Text finalScoreText;

        public float objectSpawnXPosition;
        public int objectsMoveSpeed;
        private int score = 0;
        public void Start()
        {
            Time.timeScale = 1;
        }

        public void ScoreChange()
        {
            score++;
            scoreText.text = $"Score: {score}";
        }

        public void PauseMenuActivate()
        {
            pauseMenuWindow.SetActive(!pauseMenuWindow.activeSelf);
            Time.timeScale = (int)Time.timeScale == 1 ? 0 : 1;
        }

        public void GameOver()
        {
            Time.timeScale = 0;
            GameOverMenuWindow.SetActive(true);
            finalScoreText.text = score.ToString();
        }

        public void Restart()
        {
            SceneManager.LoadScene(0);
        }
    }
}