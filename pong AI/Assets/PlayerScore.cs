using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
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
        //PlayerScoreText.text = Score;
    }
}

