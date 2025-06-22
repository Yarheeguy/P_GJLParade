using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class Tools : MonoBehaviour
{
    public bool hit;
    public GameObject player;
    public GameObject items;
    public LayerMask interact;
    public GameObject[] workUI;
    public bool working;
    public int toolid = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hit = Physics2D.Raycast(player.transform.position, Vector2.down, 1f, interact);
        if(hit)
        {
            Collider2D col = Physics2D.OverlapCircle(player.transform.position, 2f, interact);
            if(col.gameObject.tag == "Upgrade")
            {
                toolid = 1;
            }
            else if (col.gameObject.tag == "Workshop")
            {
                toolid = 2;
            }
            else toolid = 0;

        }
        if (Input.GetKeyDown(KeyCode.E) && hit)
        {
            if (toolid == 1)
            {
                workUI[0].SetActive(true);
                items.SetActive(false);
                working = true;
            }
            else if (toolid == 2)
            {
                workUI[1].SetActive(true);
                items.SetActive(false);
                working = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape) && working||!hit && working)
        {
            workUI[toolid-1].SetActive(false);
            items.SetActive(true);
            working = false;
        }
    }
    public void exitonreturn()
    {
        workUI[toolid - 1].SetActive(false);
        items.SetActive(true);
        working = false;
    }
}
