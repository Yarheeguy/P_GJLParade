using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEditor.UnityLinker;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Upgrades : MonoBehaviour
{
    public UnlockingAreas[] area;
    public GameObject[] upgradeButtons;
    public Material_Inventory mats;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < area.Length; i++)
        {
            if (area[i].isUnlocked)
            {
                upgradeButtons[i].SetActive(false);
            }
            else
            {
                upgradeButtons[i].SetActive(true);
            }
        }
    }
    public void Buy(int id)
    {
        if (!area[id].isUnlocked)
        if (mats.money >= area[id].requiredmoney)
        {
            mats.money = mats.money - area[id].requiredmoney;
            area[id].isUnlocked = true;
        }
    }
    public void UP1 ()
    {
        Buy(0);
    }
    public void UP2()
    {
        Buy(1);
    }
    public void UP3()
    {
        Buy(2);
    }
}
