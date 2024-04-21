using UnityEngine;

public class ResetScore : MonoBehaviour
{
    private void OnMouseDown()
    {
        ScoreManager.instance.score = 0;
        ScoreManager.instance.ResetScore();
        Debug.Log("Score Reset to 0");
    }
    public void ResetScoreFunction()
    {
        ScoreManager.instance.score = 0;
        ScoreManager.instance.ResetScore();
        Debug.Log("Score Reset to 0");
    }
}
