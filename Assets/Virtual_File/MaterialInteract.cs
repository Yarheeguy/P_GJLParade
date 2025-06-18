using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class MaterialInteract : MonoBehaviour
{
    public LayerMask material;
    public GameObject player;
    public Material_Inventory mats;
    public bool solid;
    public bool once = false;
    public float duration = 0.5f;
    public float time = 0f;
    public float chance;
    public OreSpawning[] os;
    public Teleport tp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Delay();
        solid = Physics2D.Raycast(player.transform.position, Vector2.down, 1f, material);
        if (solid && Input.GetMouseButton(1))
        {
            Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, 1f, material);
            foreach (Collider2D obj in objects)
            {
                if (obj.gameObject.tag == "Iron"&&once)
                {
                    once = false;
                    IronCollect();
                    Destroy(obj.gameObject);
                    os[tp.zoneID].oreSpawned--;
                }
                if (obj.gameObject.tag == "Gold" && once)
                {
                    once = false;
                    GoldCollect();
                    Destroy(obj.gameObject);
                    os[tp.zoneID].oreSpawned--;
                }
                if (obj.gameObject.tag == "Copper" && once)
                {
                    once = false;
                    CopperCollect();
                    Destroy(obj.gameObject);
                    os[tp.zoneID].oreSpawned--;
                }
                if (obj.gameObject.tag == "Gem" && once)
                {
                    once = false;
                    GemsCollect();
                    Destroy(obj.gameObject);
                    os[tp.zoneID].oreSpawned--;
                }
            }
        }
    }
    public void Delay()
    {
        if (!once)
        {
            time += Time.deltaTime;
            if (time > duration)
            {
                once = true;
                time = 0f;
            }
        }
    }
    public void IronCollect()
    {
        chance = UnityEngine.Random.Range(0f, 1f);
        if (chance > 0f)
        {
            mats.iron += 1;
            if(chance > 0.5f)
            {
                mats.iron += 1;
                if(chance > 0.8f)
                {
                    mats.iron += 1;
                }
            }
        }
    }
    public void GoldCollect()
    {
        chance = UnityEngine.Random.Range(0f, 1f);
        if (chance > 0f)
        {
            mats.gold += 1;
            if (chance > 0.66f)
            {
                mats.gold += 1;
                if (chance > 0.9f)
                {
                    mats.gold += 1;
                }
            }
        }
    }
    public void CopperCollect()
    {
        chance = UnityEngine.Random.Range(0f, 1f);
        if (chance > 0f)
        {
            mats.copper += 1;
            if (chance > 0.5f)
            {
                mats.copper += 1;
                if (chance > 0.8f)
                {
                    mats.copper += 1;
                }
            }
        }
    }
    public void GemsCollect()
    {
        chance = UnityEngine.Random.Range(0f, 1f);
        if (chance > 0f)
        {
            mats.gems += 1;
            if (chance > 0.78f)
            {
                mats.gems += 1;
            }
        }
    }
}
