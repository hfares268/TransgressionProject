using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScore : MonoBehaviour
{
    public Text Scoreboard;
    public GameObject ball;
    public Text scoreText;

    private int player1score = 0;
    private int player2score = 0;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    private void OnCollisionEnter()
    {
        player1score++;
        ball.transform.position = new Vector2(0, transform.position.y);
        scoreText.text = "Player 1:" + player1score;
    }
    /*
        if (ball.transform.position.x <= -17)
        {
            player2score++;
        }

        Scoreboard.text = player1score.ToString() + " - " + player2score.ToString();

        print(player1score + " , " + player2score);
        */
    }
