using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    private void Update()
    {
        scoreText.text = "Score: " + ScoreManager.instance.score.ToString();
        highScoreText.text = "High Score: " + ScoreManager.instance.highScore.ToString();
    }
}
