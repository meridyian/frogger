using UnityEngine.SceneManagement;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //frog arrives
    void OnTriggerEnter2D()
    {
        Score.CurrentScore += 100;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
