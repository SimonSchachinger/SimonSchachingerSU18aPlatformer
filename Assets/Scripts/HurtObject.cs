using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HurtObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {//laddar om banan när spelaren dör
        if (collision.gameObject.tag == "Player")
        {
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);
        }
    }

}
