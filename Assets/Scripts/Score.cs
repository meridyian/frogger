using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;

    public Text scoreText;


    // hold scores at start since it changes with every  scene renewal
    void Start()
    {
        scoreText.text = CurrentScore.ToString();
    }



}
