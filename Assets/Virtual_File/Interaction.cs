using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject player;
    public bool hit;
    public int toolid;
    public bool walkable;
    public LayerMask interact;
    public LayerMask walk;
    public UiControl uiControl;
    public int id;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //walkable = Physics2D.Raycast(player.transform.position, Vector2.down, 1f,walk);
        hit = Physics2D.Raycast(player.transform.position, Vector2.down, 1f, interact);

        if(hit)
        {
            Collider2D col = Physics2D.OverlapCircle(player.transform.position, 2f, interact);
            if (Input.GetKeyDown(KeyCode.E) && !uiControl.active&&col.gameObject.tag=="Portal")
            {
                uiControl.Open();
            }

        }
        
        if (uiControl.active&&!hit)
        {
            uiControl.Close();
        }
    }
}
