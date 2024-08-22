using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI scoreText;
    void Start()
    {
        count = 0;
        scoreText.text = "Coins: " + count.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            count++;
            scoreText.text = "Coins: " + count.ToString();
            Destroy(other.gameObject);
        }
    }
}
