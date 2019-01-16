using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    public int touches;
    //om du nuddar marken 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ökar touches med 1
        touches++;
    }
    //om du inte nuddar marken 
    private void OnTriggerExit2D(Collider2D collision)
    {
        // minskar touches med 1
        touches--;
    }


}
