using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public AudioSource sfx;
    public AudioClip death_sfx;
    [SerializeField] readonly AudioSource deathSound;

    bool dead = false;

    private void Update()
    {
        if (transform.position.y < -1f && !dead)
        {
            Die();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy Body"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerMotion>().enabled = false;
            Die();
        }
    }

    void Die()
    { 
        Invoke(nameof(ReloadLevel), 1.3f);
        dead = true;
        sfx.clip = death_sfx;
        sfx.Play();
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}