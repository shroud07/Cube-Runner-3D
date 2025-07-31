using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Text startText;
    public Text ScoreText;
    public Text scoreNumber;
    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;

    private void Start()
    {
        ScoreText.enabled = true;
        scoreNumber.enabled = true;
        startText.enabled = true;
        gameOverPanel.SetActive(false);
        pauseGame();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            startGame();
            startText.enabled = false;
        }
    }
    public void gameOver()
    {
        ScoreText.enabled = false;
        scoreNumber.enabled = false;
        gameOverPanel.SetActive(true);
        audio3.Play();
    }

    public void restart()
    {
        audio3.Stop();
        SceneManager.LoadScene("Game");
    }

    public void quit()
    {
        Application.Quit();
    }

    public void pauseGame()
    {
        Time.timeScale = 0f;
    }

    public void startGame()
    {
        audio4.Stop();
        Time.timeScale = 1f;
        audio1.Play();
        audio2.PlayDelayed(1f);

    }

    public void stopBGM()
    {
        audio2.Stop();
    }
}
