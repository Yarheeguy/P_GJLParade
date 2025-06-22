using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Load : MonoBehaviour
{
    public Vector2 playerpos;
    public GameObject player;
    public UnlockingAreas[] ula;
    public Material_Inventory MI;
    public Teleport tp;
    public Button[] HeadB;
    public Button[] BodyB;
    public Button[] ArmsB;
    public Button[] LegsB;
    public Button[] EyesB;
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
        data.headid = new int[5];
        data.bodyid = new int[5];
        data.armsid = new int[5];
        data.legsid = new int[5];
        data.eyesid = new int[5];
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
        for (int i = 0; i < 5; i++)
        {
            if (HeadB[i].interactable)
            {
                data.headid[i] = 1; 
            }
            else
            {
                data.headid[i] = 0; 
            }
            if (BodyB[i].interactable)
            {
                data.bodyid[i] = 1;
            }
            else
            {
                data.bodyid[i] = 0;
            }
            if (ArmsB[i].interactable)
            {
                data.armsid[i] = 1;
            }
            else
            {
                data.armsid[i] = 0;
            }
            if (LegsB[i].interactable)
            {
                data.legsid[i] = 1;
            }
            else
            {
                data.legsid[i] = 0;
            }
            if (EyesB[i].interactable)
            {
                data.eyesid[i] = 1;
            }
            else
            {
                data.eyesid[i] = 0;
            }
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
        for (int i = 0; i < 5; i++)
        {
            if (data.headid[i] == 1)
            {
                HeadB[i].interactable = true;
            }
            else
            {
                HeadB[i].interactable = false;
            }
            if (data.bodyid[i] == 1)
            {
                BodyB[i].interactable = true;
            }
            else
            {
                BodyB[i].interactable = false;
            }
            if (data.armsid[i] == 1)
            {
                ArmsB[i].interactable = true;
            }
            else
            {
                ArmsB[i].interactable = false;
            }
            if (data.legsid[i] == 1)
            {
                LegsB[i].interactable = true;
            }
            else
            {
                LegsB[i].interactable = false;
            }
            if (data.eyesid[i] == 1)
            {
                EyesB[i].interactable = true;
            }
            else
            {
                EyesB[i].interactable = false;
            }
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
    public int[] headid;
    public int[] bodyid;
    public int[] armsid;
    public int[] legsid;
    public int[] eyesid;
}