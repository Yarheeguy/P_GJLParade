using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FeedbackDisplay : MonoBehaviour
{
    [SerializeField] GameObject finddata;

    [SerializeField] GameObject feedbacktextbox1;
    [SerializeField] GameObject feedbacktextbox2;
    [SerializeField] GameObject feedbacktextbox3;


    // Update is called once per frame
    void Update()
    {
        feedbacktextbox1.GetComponent<TextMeshProUGUI>().text = finddata.GetComponent<FeedbackData>().Keyword1;
        feedbacktextbox2.GetComponent<TextMeshProUGUI>().text = finddata.GetComponent<FeedbackData>().Keyword2;
        feedbacktextbox3.GetComponent<TextMeshProUGUI>().text = finddata.GetComponent<FeedbackData>().Keyword3;
    }
}
