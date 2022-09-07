using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{

    private int Score;
    public Text ScoreText;

    void Start()
    {
        Score = 0;
        ScoreText.text = "Score" + Score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D Coin)
    {
        if(Coin.gameObject.tag == "Coin")
        {
            Score += 1;
            Destroy(Coin.gameObject);
            ScoreText.text = "Score" + Score.ToString();
        }
    }
}
