using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OreSpawning : MonoBehaviour
{
    public int orelimit = 10;
    public int oreSpawned = 0;// 0: Iron, 1: Copper, 2: Gold
    public GameObject[] orePrefab;
    public Textures tx;
    public GameObject spawnzone;
    public int[] variant;
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
    public bool once;
    float time;
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
        delay();

            while (oreSpawned < 10&&once)
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
                if(x==0)
                IronTexture();
            else if (x == 1)
                CopperTexture();
            else if (x == 2)
                GoldTexture();
            else if (x == 3)
                CrystalTexture();


        Instantiate(orePrefab[x], spawnPosition, Quaternion.identity);
                oreSpawned++;
                once = false;
            }

    }
    public void IronTexture()
    {
        variant[x]= Random.Range(0, tx.ironvar.Length);
        orePrefab[x].GetComponent<SpriteRenderer>().sprite = tx.ironvar[variant[x]];
    }
    public void CopperTexture()
    {
        variant[x] = Random.Range(0, tx.coppervar.Length);
        orePrefab[x].GetComponent<SpriteRenderer>().sprite = tx.coppervar[variant[x]];

    }
    public void GoldTexture()
    {
        variant[x] = Random.Range(0, tx.goldvar.Length);
        orePrefab[x].GetComponent<SpriteRenderer>().sprite = tx.goldvar[variant[x]];
    }
    public void CrystalTexture()
    {
        variant[x] = Random.Range(0, tx.crystalvar.Length);
        orePrefab[x].GetComponent<SpriteRenderer>().sprite = tx.crystalvar[variant[x]];
    }
    public void delay()
    {
        if (!once)
        {
            time += Time.deltaTime;
            if (time >= 8)
            {
                time = 0;
                once = true;
            }
        }
    }
}
