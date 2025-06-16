using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingProgram : MonoBehaviour
{
    public float xmove;
    public float ymove;
    public GameObject player;
    public LayerMask walk;
    public LayerMask players;
    public bool walkable;
    public float speed=5f;
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        walkable = Physics2D.OverlapBox(player.transform.position , new Vector2(0.5f, 0.5f), 0f, walk + ~players);
        if (walkable)
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
