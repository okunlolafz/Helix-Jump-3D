using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    public static int currentLevelIndex;
    public static bool gameOver;
    public static bool levelCompleted;
    public static bool isGameStarted;
    public static bool mute = false;

    public GameObject gameOverPanel;
    public GameObject LevelCompletedPanel;
    public GameObject gamePlayPanel;
    public GameObject startMenuPanel;

    public Slider progressSlider;
    
    public TextMeshProUGUI currentLevel;
    public TextMeshProUGUI nextLevel;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    public static int numberOfPassedRings;
    public static int score = 0;


    private void Awake()
    {
        currentLevelIndex = PlayerPrefs.GetInt("currentLevelIndex", 1);
    }

    // Start is called before the first frame update
    void Start()
    {
        numberOfPassedRings = 0;
        Time.timeScale = 1;
        highScoreText.text = "High Score\n" + PlayerPrefs.GetInt("HighScore", 0);
        isGameStarted = gameOver = levelCompleted = false;
    }

    // Update is called once per frame
    void Update()
    {
        currentLevel.text = currentLevelIndex.ToString();
        nextLevel.text = (currentLevelIndex +1 ).ToString();

        int progress = numberOfPassedRings * 100 / FindObjectOfType<HelixManager>().numberOfRings;
        progressSlider.value = progress;
        scoreText.text = "Score: " + score;

        if (Input.GetMouseButton(0) && !isGameStarted)
        {
            if (EventSystem.current.IsPointerOverGameObject())
                return;
            
            isGameStarted = true;
            gamePlayPanel.SetActive(true);
            startMenuPanel.SetActive(false);
        }

        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);

            if (Input.GetMouseButton(0))
            {
                if (score > PlayerPrefs.GetInt("HighScore", 0))
                {
                    PlayerPrefs.SetInt("HighScore", score);
                }
                score = 0;
                SceneManager.LoadScene(0);
            }
        }

        if (levelCompleted)
        {
            LevelCompletedPanel.SetActive(true);

            if (Input.GetMouseButton(0))
            {
                if (SceneManager.GetActiveScene().buildIndex == 4)
                {
                    SceneManager.LoadScene(0);
                }
                else
                {
                    PlayerPrefs.SetInt("currentLevelIndex", currentLevelIndex + 1);
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        }
    }
}