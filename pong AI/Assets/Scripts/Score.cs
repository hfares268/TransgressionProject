﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform ball;
    public Text scoreText;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ball.position.ToString("0");
    }
}