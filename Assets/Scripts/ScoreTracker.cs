using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
// using UnityEngine.UI
public class ScoreTracker : MonoBehaviour
{
    // spesificerar vilken varabel av den gröna typen man menar
    public TMPro.TextMeshProUGUI scoreText;
    public int totalScore;

    private void Update()
    {//visar en räknare som räknar antalet coins man har tagit
        scoreText.text = string.Format("Score: {0}", totalScore);
    }

}
