using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FeedbackData : MonoBehaviour
{
    
    [SerializeField] public string feedback1Type;
    [SerializeField] public string Keyword1;

    [SerializeField] public string feedback2Type;
    [SerializeField] public string Keyword2;

    [SerializeField] public string feedback3Type;
    [SerializeField] public string Keyword3;


    [SerializeField] public float profit;

    [SerializeField] public int StarRating;

    private void Update()
    {
        if(StarRating < 0)
        {
            StarRating = 0;
        }

        if(StarRating >= 5)
        {
            SceneManager.LoadScene("WinningScene");
        }
    }
}
