using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScoreScript : MonoBehaviour
{
    private int Score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Addscore();
    }

    void Addscore()
    {
        Score++;
        // EnemyScoreText.text = Score; 
    }
}