using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{
    public void OnReturnButton()
    {
        ScoreManager.instance.score = 0;
        ScoreManager.instance.ResetScore();
        Debug.Log("Score Reset to 0");
        SceneManager.LoadScene(0);
    }
}
