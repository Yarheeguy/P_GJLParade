using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindResult : MonoBehaviour
{
    [SerializeField] GameObject findFeedbackData;

    [SerializeField] GameObject FindHead;
    [SerializeField] GameObject FindEyes;
    [SerializeField] GameObject FindChest;
    [SerializeField] GameObject FindArms;
    [SerializeField] GameObject FindLegs;




    [SerializeField] public bool Feedback1Result;
    [SerializeField] public bool Feedback2Result;
    [SerializeField] public bool Feedback3Result;


    [SerializeField] public int positive;

    [SerializeField] public int negative;

    [SerializeField] float profit1;
    [SerializeField] float profit2;
    [SerializeField] float profit3;

    [SerializeField] float minprofitadd;
    [SerializeField] float maxprofitadd;



    public void GetResult()
    {
        //feedback1
        if(findFeedbackData.GetComponent<FeedbackData>().feedback1Type == "Functionality")
        {
            if(findFeedbackData.GetComponent<FeedbackData>().Keyword1 == FindHead.GetComponent<RobotB_PartData>().Functionality)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword1 == FindEyes.GetComponent<RobotB_PartData>().Functionality)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword1 == FindChest.GetComponent<RobotB_PartData>().Functionality)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword1 == FindArms.GetComponent<RobotB_PartData>().Functionality)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword1 == FindLegs.GetComponent<RobotB_PartData>().Functionality)
            {
                Feedback1Result = true;
            }

        }

        if (findFeedbackData.GetComponent<FeedbackData>().feedback1Type == "Apperance")
        {
            if (findFeedbackData.GetComponent<FeedbackData>().Keyword1 == FindHead.GetComponent<RobotB_PartData>().Apperance)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword1 == FindEyes.GetComponent<RobotB_PartData>().Apperance)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword1 == FindChest.GetComponent<RobotB_PartData>().Apperance)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword1 == FindArms.GetComponent<RobotB_PartData>().Apperance)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword1 == FindLegs.GetComponent<RobotB_PartData>().Apperance)
            {
                Feedback1Result = true;
            }

        }

        if (findFeedbackData.GetComponent<FeedbackData>().feedback1Type == "Extra")
        {
            if (findFeedbackData.GetComponent<FeedbackData>().Keyword1 == FindHead.GetComponent<RobotB_PartData>().Extra)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword1 == FindEyes.GetComponent<RobotB_PartData>().Extra)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword1 == FindChest.GetComponent<RobotB_PartData>().Extra)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword1 == FindArms.GetComponent<RobotB_PartData>().Extra)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword1 == FindLegs.GetComponent<RobotB_PartData>().Extra)
            {
                Feedback1Result = true;
            }

        }


        if(Feedback1Result == true)
        {
            positive = positive + 1;
        }
        else if(Feedback1Result == false)
        {
            negative = negative + 1;
        }


        //Feedback2
        if (findFeedbackData.GetComponent<FeedbackData>().feedback2Type == "Functionality")
        {
            if (findFeedbackData.GetComponent<FeedbackData>().Keyword2 == FindHead.GetComponent<RobotB_PartData>().Functionality)
            {
                Feedback2Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword2 == FindEyes.GetComponent<RobotB_PartData>().Functionality)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword2 == FindChest.GetComponent<RobotB_PartData>().Functionality)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword2 == FindArms.GetComponent<RobotB_PartData>().Functionality)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword2 == FindLegs.GetComponent<RobotB_PartData>().Functionality)
            {
                Feedback1Result = true;
            }

        }

        if (findFeedbackData.GetComponent<FeedbackData>().feedback2Type == "Apperance")
        {
            if (findFeedbackData.GetComponent<FeedbackData>().Keyword2 == FindHead.GetComponent<RobotB_PartData>().Apperance)
            {
                Feedback2Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword2 == FindEyes.GetComponent<RobotB_PartData>().Apperance)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword2 == FindChest.GetComponent<RobotB_PartData>().Apperance)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword2 == FindArms.GetComponent<RobotB_PartData>().Apperance)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword2 == FindLegs.GetComponent<RobotB_PartData>().Apperance)
            {
                Feedback1Result = true;
            }

        }

        if (findFeedbackData.GetComponent<FeedbackData>().feedback2Type == "Extra")
        {
            if (findFeedbackData.GetComponent<FeedbackData>().Keyword2 == FindHead.GetComponent<RobotB_PartData>().Extra)
            {
                Feedback2Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword2 == FindEyes.GetComponent<RobotB_PartData>().Extra)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword2 == FindChest.GetComponent<RobotB_PartData>().Extra)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword2 == FindArms.GetComponent<RobotB_PartData>().Extra)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword2 == FindLegs.GetComponent<RobotB_PartData>().Extra)
            {
                Feedback1Result = true;
            }

        }


        if (Feedback2Result == true)
        {
            positive = positive + 1;
        }
        else if (Feedback2Result == false)
        {
            negative = negative + 1;
        }


        //Feedback 3
        if (findFeedbackData.GetComponent<FeedbackData>().feedback3Type == "Functionality")
        {
            if (findFeedbackData.GetComponent<FeedbackData>().Keyword3 == FindHead.GetComponent<RobotB_PartData>().Functionality)
            {
                Feedback3Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword3 == FindEyes.GetComponent<RobotB_PartData>().Functionality)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword3 == FindChest.GetComponent<RobotB_PartData>().Functionality)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword3 == FindArms.GetComponent<RobotB_PartData>().Functionality)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword3 == FindLegs.GetComponent<RobotB_PartData>().Functionality)
            {
                Feedback1Result = true;
            }

        }

        if (findFeedbackData.GetComponent<FeedbackData>().feedback3Type == "Apperance")
        {
            if (findFeedbackData.GetComponent<FeedbackData>().Keyword3 == FindHead.GetComponent<RobotB_PartData>().Apperance)
            {
                Feedback3Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword3 == FindEyes.GetComponent<RobotB_PartData>().Apperance)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword3 == FindChest.GetComponent<RobotB_PartData>().Apperance)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword3 == FindArms.GetComponent<RobotB_PartData>().Apperance)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword3 == FindLegs.GetComponent<RobotB_PartData>().Apperance)
            {
                Feedback1Result = true;
            }

        }

        if (findFeedbackData.GetComponent<FeedbackData>().feedback3Type == "Extra")
        {
            if (findFeedbackData.GetComponent<FeedbackData>().Keyword3 == FindHead.GetComponent<RobotB_PartData>().Extra)
            {
                Feedback3Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword3 == FindEyes.GetComponent<RobotB_PartData>().Extra)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword3 == FindChest.GetComponent<RobotB_PartData>().Extra)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword3 == FindArms.GetComponent<RobotB_PartData>().Extra)
            {
                Feedback1Result = true;
            }

            if (findFeedbackData.GetComponent<FeedbackData>().Keyword3 == FindLegs.GetComponent<RobotB_PartData>().Extra)
            {
                Feedback1Result = true;
            }

        }


        if (Feedback3Result == true)
        {
            positive = positive + 1;
        }
        else if (Feedback3Result == false)
        {
            negative = negative + 1;
        }


        if(positive == 1 & negative == 2)
        {
            profit1 = Random.Range(minprofitadd, maxprofitadd);
            profit2 = 0;
            profit3 = 0;
        }


        if (positive == 2 & negative == 1)
        {
            profit1 = Random.Range(minprofitadd, maxprofitadd);
            profit2 = Random.Range(minprofitadd, maxprofitadd);
            profit3 = 0;
        }

        if (positive == 3)
        {
            profit1 = Random.Range(minprofitadd, maxprofitadd);
            profit2 = Random.Range(minprofitadd, maxprofitadd);
            profit3 = Random.Range(minprofitadd, maxprofitadd);
        }

        if (negative == 0)
        {
            profit1 = 0;
            profit2 = 0;
            profit3 = 0;
        }

        findFeedbackData.GetComponent<FeedbackData>().profit = profit1 + profit2 + profit3;

    }


}
