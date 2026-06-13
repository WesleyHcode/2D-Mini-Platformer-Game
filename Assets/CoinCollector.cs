using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    public int score = 0;

    public TextMeshProUGUI scoreText;

    public AudioSource audioSource;

    public AudioClip coinSound;

    void Start()
    {
        UpdateScore();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Coin"))
        {
            score++;

            if(audioSource != null &&
               coinSound != null)
            {
                audioSource.PlayOneShot(
                    coinSound);
            }

            Destroy(other.gameObject);

            UpdateScore();
        }
    }

    void UpdateScore()
    {
        scoreText.text =
            "Score: " + score;
    }
}