using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackGenerator : MonoBehaviour
{

    [SerializeField] GameObject finddata;

    [SerializeField] int feedback1type;
    [SerializeField] int feedback2type;
    [SerializeField] int feedback3type;

    [SerializeField] int minmark1;

    [SerializeField] int maxmark1;

    [SerializeField] string[] keyword1;

    [SerializeField] int markKeyword1;

    [SerializeField] int minmark2;

    [SerializeField] int maxmark2;

    [SerializeField] string[] keyword2;

    [SerializeField] int markKeyword2;


    [SerializeField] int minmark3;

    [SerializeField] int maxmark3;

    [SerializeField] string[] keyword3;

    [SerializeField] int markKeyword3;


    //delete this later
    private void Start()
    {
        generateFeedback();
    }



    public void generateFeedback()
    {
        feedback1type = Random.Range(0, 3);
        feedback2type = Random.Range(0, 3);
        feedback3type = Random.Range(0, 3);

        if (feedback1type == 0)
        {
            markKeyword1 = Random.Range(minmark1, maxmark1);
            finddata.GetComponent<FeedbackData>().Keyword1 = keyword1[markKeyword1];
            finddata.GetComponent<FeedbackData>().feedback1Type = "Functionality";
        }

        if (feedback1type == 1)
        {
            markKeyword2 = Random.Range(minmark2, maxmark2);
            finddata.GetComponent<FeedbackData>().Keyword1 = keyword2[markKeyword2];
            finddata.GetComponent<FeedbackData>().feedback1Type = "Apperance";
        }

        if (feedback1type == 2)
        {
            markKeyword3 = Random.Range(minmark3, maxmark3);
            finddata.GetComponent<FeedbackData>().Keyword1 = keyword3[markKeyword3];
            finddata.GetComponent<FeedbackData>().feedback1Type = "Extra";
        }

        if (feedback2type == 0)
        {
            markKeyword1 = Random.Range(minmark1, maxmark1);
            finddata.GetComponent<FeedbackData>().Keyword2 = keyword1[markKeyword1];
            finddata.GetComponent<FeedbackData>().feedback2Type = "Functionality";
        }

        if (feedback2type == 1)
        {
            markKeyword2 = Random.Range(minmark2, maxmark2);
            finddata.GetComponent<FeedbackData>().Keyword2 = keyword2[markKeyword2];
            finddata.GetComponent<FeedbackData>().feedback2Type = "Apperance";
        }

        if (feedback2type == 2)
        {
            markKeyword3 = Random.Range(minmark3, maxmark3);
            finddata.GetComponent<FeedbackData>().Keyword2 = keyword3[markKeyword3];
            finddata.GetComponent<FeedbackData>().feedback2Type = "Extra";
        }

        if (feedback3type == 0)
        {
            markKeyword1 = Random.Range(minmark1, maxmark1);
            finddata.GetComponent<FeedbackData>().Keyword3 = keyword1[markKeyword1];
            finddata.GetComponent<FeedbackData>().feedback3Type = "Functionality";
        }

        if (feedback3type == 1)
        {
            markKeyword2 = Random.Range(minmark2, maxmark2);
            finddata.GetComponent<FeedbackData>().Keyword3 = keyword2[markKeyword2];
            finddata.GetComponent<FeedbackData>().feedback3Type = "Apperance";
        }

        if (feedback3type == 2)
        {
            markKeyword3 = Random.Range(minmark3, maxmark3);
            finddata.GetComponent<FeedbackData>().Keyword3 = keyword3[markKeyword3];
            finddata.GetComponent<FeedbackData>().feedback3Type = "Extra";
        }



    }
}
