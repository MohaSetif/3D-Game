using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    public AudioClip coin_sfx;
    public AudioSource sfx;
    public TextMeshProUGUI coinsText;

    private int coins = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;
            sfx.clip = coin_sfx;
            sfx.Play();
            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        if (coinsText != null)
        {
            coinsText.text = "Score: " + coins;
        }
        else
        {
            Debug.LogError("TextMeshProUGUI object not assigned in the Inspector!");
        }
    }
}



// public class ItemCollector : MonoBehaviour
// {
//     int coins = 0;

//     [SerializeField] TextMeshProUGUI coinsText;

//     [SerializeField] AudioSource collectionSound;

//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.gameObject.CompareTag("Coin"))
//         {
//             Destroy(other.gameObject);
//             coins++;
//             //Debug.Log(coins);
//             coinsText.text = "Coins: " + coins;
//             collectionSound.Play();
//         }
//     }
// }
