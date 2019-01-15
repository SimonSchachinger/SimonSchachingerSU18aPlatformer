using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour {
    // 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // om objektet nuddar något med taggen Player
       if (collision.tag == "Player")
        {
            // förstör objektet och dess parent
            Destroy(transform.parent.gameObject);
        }
    }
}
