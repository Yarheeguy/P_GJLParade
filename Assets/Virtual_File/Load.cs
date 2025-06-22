using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{
    public Vector2 playerpos;
    public GameObject player;
    public UnlockingAreas[] ula;
    public Material_Inventory MI;
    public Teleport tp;
    public int[] upgradeid;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private static Load instance;
    public static Load Instance
    {
        get
        {
            if(!Application.isPlaying)
            {
                return null;
            }
            if (instance == null)
            {
                Instantiate(Resources.Load<Load>("Load"));


            }
            return instance;
        }
    }
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
        
        for (int i = 0; i < upgradeid.Length; i++)
        {
            if (ula[i].isUnlocked)
            {
                upgradeid[i] = 1;
            }
            else if (ula[i].isUnlocked)
            {
                upgradeid[i] = 2;
            }
            // Add more conditions as needed for other upgrade IDs
        }

    }
    public void Save(ref PlayerSaveData data)
    {
        data.upgradeid = new int[upgradeid.Length];
        data.playerpos = player.transform.position;
        data.iron = MI.iron;
        data.copper = MI.copper;
        data.gold = MI.gold;
        data.gems = MI.gems;
        data.money = MI.money;
        data.review = MI.review;
        data.zoneID = tp.zoneID;
        for (int i = 0; i < upgradeid.Length; i++)
        {
             data.upgradeid[i] = upgradeid[i];
        }

    }
    public void LoadData(PlayerSaveData data)
    {
        tp.zoneID = data.zoneID;
        MI.iron = data.iron;
        MI.copper = data.copper;
        MI.gold = data.gold;
        MI.gems = data.gems;
        MI.money = data.money;
        MI.review = data.review;
        player.transform.position = data.playerpos;
        for(int i = 0; i < data.upgradeid.Length; i++)
        {
           upgradeid[i] = data.upgradeid[i];
        }
        for (int i = 0; i < upgradeid.Length; i++)
        {
            if (upgradeid[i]==1)
            {
                ula[i].isUnlocked = true;
            }
            else if (upgradeid[i] ==2)
            {
                ula[i].isUnlocked = false;
            }
            // Add more conditions as needed for other upgrade IDs
        }
    }
    
}
[System.Serializable]
public struct PlayerSaveData
{
    public Vector2 playerpos;
    public int zoneID;
    public int iron;
    public int copper;
    public int gold;
    public int gems;
    public int money;
    public float review;
    public int[] upgradeid;
}