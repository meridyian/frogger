using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using System;

public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI totalScoreText;

    public UnityAction OnLevelEnd;

    public EndMenu endmenu;

    public RestartMenu restartmenu;


    // hold scores at start since it changes with every  scene renewal
    void Start()
    {
        OnLevelEnd += ShowButton;
        scoreText.text = CurrentScore.ToString();
    }

    private void ShowButton()
    {
        endmenu.gameObject.SetActive(true);
        restartmenu.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(false);
        scoreText.text = CurrentScore.ToString();
        totalScoreText.gameObject.SetActive(true);
        totalScoreText.text = "Total Score: " + CurrentScore.ToString();

    }

    

}
