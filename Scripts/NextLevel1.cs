using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel1 : MonoBehaviour
{

    void OnMouseDown()
    {
        SceneManager.LoadScene(2);
    }
}
