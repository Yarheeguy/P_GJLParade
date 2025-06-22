using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    public GameObject player;
    public GameObject[] teleportPoints;
    public int zoneID=0;
    public int idt = 0;
    public bool teleporting = false;
    public Transitions trs;
    public UiControl ucl;
    public UnlockingAreas[] area;
    public TMPro.TextMeshProUGUI zoneText;
    public Material_Inventory mats;
    public GameObject error;
    public Interaction interaction;
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
    public async void TeleportPlayer()
    {
        if (idt >= 2)
        {
            if (!area[idt - 2].isUnlocked)
            {
                
                
            }
            if (area[idt - 2].isUnlocked)

            {
                areacheck();
            }
        }
        else areacheck();

    }
    public void areacheck()
    {
            if (idt != zoneID)
            {
                ucl.Close();
                teleporting = true;
                zoneID = idt;
                trs.CrossFade();
            }
    }    
}
