using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Frog : MonoBehaviour
{

    public Rigidbody2D rb;

    public Score score;

    public bool isDead = false;
    public Canvas deathCanvas;

    public CarSpawner carspawner;

    private void Start()
    {
        score = FindObjectOfType<Score>();
    }

    void Update()
    {
        //check for input, 4 keys

        if (Input.GetKeyDown(KeyCode.RightArrow))
            //it moves to that position, not one unit
            rb.MovePosition(rb.position + Vector2.right);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.MovePosition(rb.position + Vector2.down);


    }


    //car collision

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Car")
        {
            Die();
        }
    }

    public void Die()
    {
        score.ShowButton();
        deathCanvas.gameObject.SetActive(true); 
        isDead = true;
        Destroy(gameObject);
        
        carspawner.canspawn = false;

    }


}
