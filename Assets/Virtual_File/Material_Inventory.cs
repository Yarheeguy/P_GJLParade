using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Material_Inventory : MonoBehaviour
{
    // Start is called before the first frame update
    public int iron;
    public int gold;
    public int copper;
    public int gems;
    public int money;
    public float review;
    public TextMeshProUGUI ironText;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI copperText;
    public TextMeshProUGUI gemsText;
    public TextMeshProUGUI moneyText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ironText.text = iron.ToString();
        goldText.text = gold.ToString();
        copperText.text = copper.ToString();
        gemsText.text = gems.ToString();
        moneyText.text = money.ToString();
        if(review <0)
        {
            review = 0;
        }
        if (review >5)
        {
            review = 5;
        }

    }

}
