using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{

    public Text bestScoreText;


    private void Start()
    {
        bestScoreText.text = $"Best Score: {BestScore.userInput}  {BestScore.userNum}";
    }





}//class




