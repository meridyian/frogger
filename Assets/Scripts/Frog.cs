using UnityEngine;

public class Frog : MonoBehaviour{

    public Rigidbody2D rb;

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
}
