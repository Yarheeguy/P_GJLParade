using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject player;
    public bool hit;
    public bool walkable;
    public LayerMask interact;
    public LayerMask walk;
    public UiControl uiControl;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //walkable = Physics2D.Raycast(player.transform.position, Vector2.down, 1f,walk);
        hit = Physics2D.Raycast(player.transform.position, Vector2.down, 1f, interact);
        if (Input.GetKeyDown(KeyCode.E)&&hit&&!uiControl.active)
        {
            uiControl.Open();
        }
        if (uiControl.active&&!hit)
        {
            uiControl.Close();
        }
    }
}
