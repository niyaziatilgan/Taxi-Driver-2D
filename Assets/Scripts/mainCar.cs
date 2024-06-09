using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCar : MonoBehaviour
{
    public float vertical_Speed;
    private float verticalMovement;
    private float horizontalMovement;
    public float horizontal_Speed;
    public float defaultSpeed;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        verticalMovement = Input.GetAxis("Vertical");
        horizontalMovement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(horizontalMovement*50*horizontal_Speed*Time.deltaTime,
            defaultSpeed + verticalMovement * vertical_Speed *50 * Time.deltaTime);

        if(transform.position.x > 1.85f)
        {
            Vector3 rightLimit = new Vector3(1.85f, transform.position.y);
            transform.position = rightLimit;
        }

        if(transform.position.x < -1.8f)
        {
            Vector3 leftLimit = new Vector3(-1.8f, transform.position.y);
            transform.position = leftLimit;
        }
    }
}
