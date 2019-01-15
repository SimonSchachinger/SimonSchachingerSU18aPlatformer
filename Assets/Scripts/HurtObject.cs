using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HurtObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {//om spelaren dör
        if (collision.gameObject.tag == "Player")
        {
            // variabeln active tilldelas den aktiva scenen
            Scene active = SceneManager.GetActiveScene();
            // laddar upp den aktiva scenen via dess namn
            SceneManager.LoadScene(active.name);
        }
    }

}
