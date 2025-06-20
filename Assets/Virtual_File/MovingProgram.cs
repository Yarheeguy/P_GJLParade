using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingProgram : MonoBehaviour
{
    public float xmove;
    public float ymove;
    public GameObject player;
    public float speed=5f;
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            Direction();
    }

    public void Direction()
    {
        xmove = Input.GetAxisRaw("Horizontal");
        ymove = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 8f;
        }
        else
        {
            speed = 5f;
        }
        rb.velocity = new Vector2(xmove * speed, ymove * speed);
    }
}
