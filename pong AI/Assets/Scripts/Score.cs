using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public Transform player;
    public Text scoreText;
    float num = 5;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.ToString();
        num = num++;
    }
}
