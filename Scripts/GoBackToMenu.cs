using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackToMenu : MonoBehaviour
{
    public AudioSource sfx;
    public AudioClip btn_sfx;
    public void EndGame()
    {
        StartCoroutine(PlaySoundAndLoadScene());
    }

    IEnumerator PlaySoundAndLoadScene()
    {
        sfx.clip = btn_sfx;
        sfx.Play();

        yield return new WaitForSeconds(sfx.clip.length);

        SceneManager.LoadScene(0);
    }
}
