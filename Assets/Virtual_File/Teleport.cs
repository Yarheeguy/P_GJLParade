using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject player;
    public GameObject[] teleportPoints;
    public int zoneID=0;
    public int idt = 0;
    public bool teleporting = false;
    public Transitions trs;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (trs.tpn)
            player.transform.position = teleportPoints[idt].transform.position;
    }
    public void TeleportPlayer()
    {
        if (idt!=zoneID)
        {
            teleporting = true;
            zoneID =idt;
            trs.CrossFade();
        }
    }
}
