using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int score = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // om objektet nuddar något med taggen Player
        if (collision.tag == "Player")
        {
            //Skapa en temporär variabel och sätt den till resultatet av sökningen efter objektet med taggen "GameController".
            GameObject controller = GameObject.FindWithTag("GameController");
            // checkar om något hittades
            if (controller != null)
            {
                //Skapa en temporär variabel "tracker" och sätt den till resultatet av sökningen efter komponenten "ScoreTracker".
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                // om ScoreTracker finns
                if (tracker != null)
                {
                    // ökar score med 1
                    tracker.totalScore += score;
                }
                // om inget hittades
                else
                {
                    // printas "ScoreTracker saknas på GameController"
                    Debug.LogError("ScoreTracker saknas på GameController");
                }
            }
            // Om inget hittades printas "GameController finns inte"
            else
            {
                //printas "GameController finns inte"
                Debug.LogError("GameController finns inte");
            }
            // förstörs objektet
            Destroy(gameObject);
        }
    }

}
