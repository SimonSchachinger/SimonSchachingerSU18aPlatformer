using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    
    public int touches;
    //om du nuddar marken kan du hoppa
    private void OnTriggerEnter2D(Collider2D collision)
    {
        touches++;
    }
    //om du inte nuddar marken kan du inte hoppa
    private void OnTriggerExit2D(Collider2D collision)
    {
        touches--;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
