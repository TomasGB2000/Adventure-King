using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Currency : MonoBehaviour
{
    public TextMeshProUGUI MyScore;
    public int ScoreNum;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 1000;
        MyScore.text = "Gold: " + ScoreNum;
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        if (collisionInfo.gameObject.tag == "Green")
        {
            ScoreNum += 10;
            MyScore.text = "Gold" + ScoreNum;
        }
        else if (collisionInfo.gameObject.tag == "Red")
        {
            ScoreNum -= 10;
            MyScore.text = "Gold" + ScoreNum;
        }
    }
}
