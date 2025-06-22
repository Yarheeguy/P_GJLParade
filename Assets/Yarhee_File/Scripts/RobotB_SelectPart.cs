using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotB_SelectPart : MonoBehaviour
{
    [SerializeField] GameObject robot;
    [SerializeField] Image part;

    [SerializeField] Sprite partsprite;

    [SerializeField] string PartFunctionality;
    [SerializeField] string PartApperance;
    [SerializeField] string PartExtra;

    public void changepart()
    {
        part.sprite = partsprite;

        robot.GetComponent<RobotB_PartData>().Functionality = PartFunctionality;
        robot.GetComponent<RobotB_PartData>().Apperance = PartApperance;
        robot.GetComponent<RobotB_PartData>().Extra = PartExtra;
    }
    

}
