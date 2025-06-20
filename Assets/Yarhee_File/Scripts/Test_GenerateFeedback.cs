using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_GenerateFeedback : MonoBehaviour
{
    [SerializeField] GameObject findfeedbackgenerator;

    // Start is called before the first frame update
    void Start()
    {
        findfeedbackgenerator.GetComponent<FeedbackGenerator>().generateFeedback();
    }


}
