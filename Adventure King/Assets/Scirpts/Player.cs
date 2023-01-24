using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float amount = 0f;

    [SerializeField] private Text goldText;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Red"))
        {
            amount -= 5;
            goldText.text = "Player 1 Gold:" + amount;
        }

        if (collision.gameObject.CompareTag("Green"))
        {
            amount += 5;
            goldText.text = "Player 1 Gold:" + amount;
        }

        if (collision.gameObject.CompareTag("Yellow"))
        {
            amount -= 50;
            goldText.text = "Player 1 Gold:" + amount;
        }

        if (collision.gameObject.CompareTag("Blue"))
        {
            amount += 50;
            goldText.text = "Player 1 Gold:" + amount;
        }
    }

}
