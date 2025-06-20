using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackGenerator : MonoBehaviour
{

    [SerializeField] GameObject finddata;

    [SerializeField] GameObject Closeresults;
    [SerializeField] GameObject Displayfeedback;

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



    [SerializeField] public string[] username;

    [SerializeField] public int usernamenumber1;
    [SerializeField] public int usernamenumber2;
    [SerializeField] public int usernamenumber3;

    [SerializeField] int maxusernames;

    [SerializeField] public int commentnumber1;
    [SerializeField] public int commentnumber2;
    [SerializeField] public int commentnumber3;

    [SerializeField] int maxcomment;



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

        usernamenumber1 = Random.Range(0, maxusernames);
        usernamenumber2 = Random.Range(0, maxusernames);
        usernamenumber3 = Random.Range(0, maxusernames);

        commentnumber1 = Random.Range(0, maxcomment);
        commentnumber2 = Random.Range(0, maxcomment);
        commentnumber3 = Random.Range(0, maxcomment);




        Closeresults.SetActive(false);
        Displayfeedback.SetActive(true);
        
    }
}
