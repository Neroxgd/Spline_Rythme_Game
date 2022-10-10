using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public float score = 0;
    public float multiplier = 0;

    public float finalScore;

    public TMP_Text ScoreText;
     public TMP_Text MultiplierText;



    public void AddperfectScore()
    {

        score  += 300;
        multiplier += 1;

    }

     public void AddGoodScore()
    {

        score  += 100;
        multiplier += 1;
    }

    public void CalculateScore()
    {

      finalScore = score * multiplier;

    }
    

    public void Update()
    {
        
        ScoreText.text = "Score : " + score;
        MultiplierText.text = "Multiplier : " + multiplier + "X" ;



    }


}
