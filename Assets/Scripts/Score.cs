using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using System;

public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;

    public GameObject divider;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI totalScoreText;


    public RestartMenu restartmenu;


    // hold scores at start since it changes with every  scene renewal
    void Start()
    {
        
        scoreText.text = CurrentScore.ToString();
    }

    public void ShowButton()
    {
         divider.SetActive(false);
            
         totalScoreText.gameObject.SetActive(true);
         totalScoreText.text = "Total Score: " + CurrentScore.ToString();
    }


    

}
