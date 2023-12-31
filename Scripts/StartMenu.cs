using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public AudioSource sfx;
    public AudioClip btn_sfx;
     public void StartGame()
    {
        StartCoroutine(PlaySoundAndLoadScene());
    }

    IEnumerator PlaySoundAndLoadScene()
    {
        sfx.clip = btn_sfx;
        sfx.Play();

        yield return new WaitForSeconds(sfx.clip.length);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}