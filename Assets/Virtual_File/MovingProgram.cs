using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class MovingProgram : MonoBehaviour
{
    public float xmove;
    public float ymove;
    public GameObject player;
    public float speed = 5f;
    public Rigidbody2D rb;
    public float time = 0f;
    public float delay = 0f;
    public GameObject image;
    void Start()
    {
        image.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        SaveTimer();
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
    public async void SaveTimer()
    {
        time += Time.deltaTime;
        if (time >= delay)
        {
            time = 0f;
            SaveSystem.Save();
            image.SetActive(true);
            await Task.Delay(4000);
            image.SetActive(false);
        }
    }
}
