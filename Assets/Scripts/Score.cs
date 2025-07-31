using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int myScore = 0;
    public Text panelScore;

    private void Start()
    {
        // Load best score when the game starts
        UpdateScoreUI();
    }

    public void addScore()
    {
        myScore++;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        scoreText.text = myScore.ToString();
        panelScore.text = myScore.ToString();
    }
}
