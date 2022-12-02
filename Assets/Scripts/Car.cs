using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1f;
    public float minSpeed = 8f;
    public float maxSpeed = 12f;


    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    //for movement purposes
    void FixedUpdate()
    {
        // transform.right needs to be converted into 2d form
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);

    }



}
