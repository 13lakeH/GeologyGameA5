using UnityEngine;

public class DecreaseScoreOnClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        ScoreManager.instance.DecreaseScore(20);
        Debug.Log("Score Decreased by 20");
    }
}