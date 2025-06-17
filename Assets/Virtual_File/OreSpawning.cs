using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreSpawning : MonoBehaviour
{
    public int orelimit = 10;
    public int oreSpawned = 0;// 0: Iron, 1: Copper, 2: Gold
    public GameObject[] orePrefab;
    public GameObject spawnzone;
    public float ironchance;
    public float copperchance;
    public float goldchance;
    public Teleport tp;
    public int x;
    public bool spwn = false;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    // Start is called before the first frame update
    void Start()
    {
        maxX = spawnzone.transform.position.x + spawnzone.transform.localScale.x / 2;
        minX = spawnzone.transform.position.x - spawnzone.transform.localScale.x / 2;
        maxY = spawnzone.transform.position.y + spawnzone.transform.localScale.y / 2;
        minY = spawnzone.transform.position.y - spawnzone.transform.localScale.y / 2;

    }

    // Update is called once per frame
    void Update()
    {
        if (!spwn)
        {
            while (oreSpawned < 10)
            {
                float posx = Random.Range(minX, maxX);
                float posy = Random.Range(minY, maxY);
                Vector2 spawnPosition = new Vector2(posx, posy);
                float chance = Random.Range(0, 1f);
                if(chance >0)
                {
                    x = 0;
                    if(chance>ironchance)
                    {
                        x++;
                        if(chance > copperchance)
                        {
                            x++;
                            if (chance > goldchance)
                            {
                                x++;
                            }
                        }
                    }
                }

                Instantiate(orePrefab[x], spawnPosition, Quaternion.identity);
                oreSpawned++;
                spwn = true;
            }
        }
        if (oreSpawned ==0)
        {
            spwn = false;
        }

    }
}
