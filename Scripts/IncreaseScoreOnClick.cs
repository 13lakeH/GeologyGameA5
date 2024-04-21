using UnityEngine;

public class IncreaseScoreOnClick : MonoBehaviour
{ 
    private void OnMouseDown()
    {
        ScoreManager.instance.IncreaseScore(50);
        Debug.Log("Score increased by 50");
    }
}