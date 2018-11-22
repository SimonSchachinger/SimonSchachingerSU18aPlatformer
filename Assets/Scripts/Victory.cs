using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public string levelToLoad = "SampleScene";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            print("Victory!");
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
