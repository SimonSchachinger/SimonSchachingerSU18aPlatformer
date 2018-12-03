using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour {
    //förstör objektet och dess parent när den nuddar spelaren
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.tag == "Player")
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
