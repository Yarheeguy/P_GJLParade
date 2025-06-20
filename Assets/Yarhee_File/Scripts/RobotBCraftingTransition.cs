using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotBCraftingTransition : MonoBehaviour
{

    [SerializeField] GameObject robot;
    [SerializeField] GameObject robotB;

    [SerializeField] GameObject crafting;
    [SerializeField] GameObject items;


    [SerializeField] GameObject publishResult;
    [SerializeField] GameObject findpubish;

    [SerializeField] GameObject feedbacklooparround;


    public void EnterRobotcrafting()
    {
        robot.SetActive(true);
        robotB.SetActive(true);
        crafting.SetActive(false);
        items.SetActive(false);

    }

    public void EnterCrafting()
    {
        robot.SetActive(false);
        robotB.SetActive(false);
        crafting.SetActive(true);
        items.SetActive(true);
    }

    public void EnterPublishing()
    {
        robot.SetActive(false);
        robotB.SetActive(false);
        findpubish.GetComponent<FindResult>().positive = 0;
        findpubish.GetComponent<FindResult>().negative = 0;
        findpubish.GetComponent<FindResult>().Feedback1Result = false;
        findpubish.GetComponent<FindResult>().Feedback2Result = false;
        findpubish.GetComponent<FindResult>().Feedback3Result = false;
        findpubish.GetComponent<FindResult>().GetResult();
        publishResult.SetActive(true);
    }

    public void LoopReturn()
    {
        robot.SetActive(true);
        robotB.SetActive(true);
        feedbacklooparround.SetActive(false);
    }
}
