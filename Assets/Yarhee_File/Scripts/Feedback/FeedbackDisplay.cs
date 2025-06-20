using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FeedbackDisplay : MonoBehaviour
{
    [SerializeField] GameObject finddata;
    [SerializeField] GameObject findresult;


    [SerializeField] GameObject feedbacktextbox1;
    [SerializeField] GameObject feedbacktextbox2;
    [SerializeField] GameObject feedbacktextbox3;

    [SerializeField] GameObject username1;
    [SerializeField] GameObject username2;
    [SerializeField] GameObject username3;


    [SerializeField] GameObject resultimage1;
    [SerializeField] GameObject resultimage2;
    [SerializeField] GameObject resultimage3;

    [SerializeField] Sprite imagepositive;
    [SerializeField] Sprite imagenegative;

    [SerializeField] GameObject commenttextbox1;
    [SerializeField] GameObject commenttextbox2;
    [SerializeField] GameObject commenttextbox3;

    [SerializeField] public string[] positivecomment;
    [SerializeField] public string[] negativecomment;



    // Update is called once per frame
    void Update()
    {

        username1.GetComponent<TextMeshProUGUI>().text = finddata.GetComponent<FeedbackGenerator>().username[finddata.GetComponent<FeedbackGenerator>().usernamenumber1];
        username2.GetComponent<TextMeshProUGUI>().text = finddata.GetComponent<FeedbackGenerator>().username[finddata.GetComponent<FeedbackGenerator>().usernamenumber2];
        username3.GetComponent<TextMeshProUGUI>().text = finddata.GetComponent<FeedbackGenerator>().username[finddata.GetComponent<FeedbackGenerator>().usernamenumber3];


        feedbacktextbox1.GetComponent<TextMeshProUGUI>().text = finddata.GetComponent<FeedbackData>().Keyword1;
        feedbacktextbox2.GetComponent<TextMeshProUGUI>().text = finddata.GetComponent<FeedbackData>().Keyword2;
        feedbacktextbox3.GetComponent<TextMeshProUGUI>().text = finddata.GetComponent<FeedbackData>().Keyword3;


        if(findresult.GetComponent<FindResult>().positive == 3)
        {
            resultimage1.GetComponent<Image>().sprite = imagepositive;
            resultimage2.GetComponent<Image>().sprite = imagepositive;
            resultimage3.GetComponent<Image>().sprite = imagepositive;

            commenttextbox1.GetComponent<TextMeshProUGUI>().text = positivecomment[finddata.GetComponent<FeedbackGenerator>().commentnumber1];
            commenttextbox2.GetComponent<TextMeshProUGUI>().text = positivecomment[finddata.GetComponent<FeedbackGenerator>().commentnumber2];
            commenttextbox3.GetComponent<TextMeshProUGUI>().text = positivecomment[finddata.GetComponent<FeedbackGenerator>().commentnumber3];
        }

        if (findresult.GetComponent<FindResult>().positive == 2)
        {
            resultimage1.GetComponent<Image>().sprite = imagepositive;
            resultimage2.GetComponent<Image>().sprite = imagenegative;
            resultimage3.GetComponent<Image>().sprite = imagepositive;

            commenttextbox1.GetComponent<TextMeshProUGUI>().text = positivecomment[finddata.GetComponent<FeedbackGenerator>().commentnumber1];
            commenttextbox2.GetComponent<TextMeshProUGUI>().text = negativecomment[finddata.GetComponent<FeedbackGenerator>().commentnumber2];
            commenttextbox3.GetComponent<TextMeshProUGUI>().text = positivecomment[finddata.GetComponent<FeedbackGenerator>().commentnumber3];
        }

        if (findresult.GetComponent<FindResult>().positive == 1)
        {
            resultimage1.GetComponent<Image>().sprite = imagepositive;
            resultimage2.GetComponent<Image>().sprite = imagenegative;
            resultimage3.GetComponent<Image>().sprite = imagenegative;

            commenttextbox1.GetComponent<TextMeshProUGUI>().text = positivecomment[finddata.GetComponent<FeedbackGenerator>().commentnumber1];
            commenttextbox2.GetComponent<TextMeshProUGUI>().text = negativecomment[finddata.GetComponent<FeedbackGenerator>().commentnumber2];
            commenttextbox3.GetComponent<TextMeshProUGUI>().text = negativecomment[finddata.GetComponent<FeedbackGenerator>().commentnumber3];
        }

        if (findresult.GetComponent<FindResult>().positive == 0)
        {
            resultimage1.GetComponent<Image>().sprite = imagenegative;
            resultimage2.GetComponent<Image>().sprite = imagenegative;
            resultimage3.GetComponent<Image>().sprite = imagenegative;

            commenttextbox1.GetComponent<TextMeshProUGUI>().text = negativecomment[finddata.GetComponent<FeedbackGenerator>().commentnumber1];
            commenttextbox2.GetComponent<TextMeshProUGUI>().text = negativecomment[finddata.GetComponent<FeedbackGenerator>().commentnumber2];
            commenttextbox3.GetComponent<TextMeshProUGUI>().text = negativecomment[finddata.GetComponent<FeedbackGenerator>().commentnumber3];
        }
    }
}
