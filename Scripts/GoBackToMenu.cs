using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToMenu : MonoBehaviour
{
    public void EndGame()
    {
        int i = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(i = 0);
    }
}
