using UnityEngine.SceneManagement;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //frog arrives
    void OnTriggerEnter2D()
    {
        Debug.Log("YOU WON!!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
