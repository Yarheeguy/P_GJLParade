using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayResults : MonoBehaviour
{
    public Material_Inventory MI;
    [SerializeField] GameObject findresults;
    [SerializeField] GameObject findfeedbackdata;
    public bool once=false;

    [SerializeField] GameObject responsetext;

    [SerializeField] GameObject profit;

    [SerializeField] float displayprofit;


    [SerializeField] GameObject starrating;
    [SerializeField] Sprite[] stars;


    // Update is called once per frame
    void Update()
    {
        if(findfeedbackdata.GetComponent<FeedbackData>().profit != 0)
        {
            money();
            displayprofit = findfeedbackdata.GetComponent<FeedbackData>().profit / 1000;
        }

        profit.GetComponent<TextMeshProUGUI>().text = "Money: " + displayprofit.ToString("0.0") + "K";


        if(findresults.GetComponent<FindResult>().positive == 3)
        {
            responsetext.GetComponent<TextMeshProUGUI>().text = "Brillaint Product! and it can be better!";
        }


        if (findresults.GetComponent<FindResult>().positive == 2)
        {
            responsetext.GetComponent<TextMeshProUGUI>().text = "Product is Above Average, room for improvement.";
        }

        if (findresults.GetComponent<FindResult>().positive == 1)
        {
            responsetext.GetComponent<TextMeshProUGUI>().text = "Below average product, you did your best.";
        }

        if (findresults.GetComponent<FindResult>().positive == 0)
        {
            responsetext.GetComponent<TextMeshProUGUI>().text = "Not what the customer wanted, Try again.";
        }

        starrating.GetComponent<Image>().sprite = stars[findfeedbackdata.GetComponent<FeedbackData>().StarRating];

    }
    public void money()
    {
        if(once)
        {
            MI.money += (int)findfeedbackdata.GetComponent<FeedbackData>().profit;
            once = false;
        }
    }
}
