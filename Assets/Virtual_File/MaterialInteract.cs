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
                if (obj.gameObject.name == "Iron"&&once)
                {
                    once = false;
                    IronCollect();
                    Destroy(obj.gameObject);
                }
                if (obj.gameObject.name == "Gold" && once)
                {
                    once = false;
                    GoldCollect();
                    Destroy(obj.gameObject);
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
}
