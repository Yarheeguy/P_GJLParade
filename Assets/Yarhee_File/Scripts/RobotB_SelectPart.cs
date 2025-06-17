using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotB_SelectPart : MonoBehaviour
{
    [SerializeField] GameObject part;

    [SerializeField] Sprite partsprite;

    [SerializeField] string PartFunctionality;
    [SerializeField] string PartApperance;
    [SerializeField] string PartExtra;

    public void changepart()
    {
        part.GetComponent<SpriteRenderer>().sprite = partsprite;

        part.GetComponent<RobotB_PartData>().Functionality = PartFunctionality;
        part.GetComponent<RobotB_PartData>().Apperance = PartApperance;
        part.GetComponent<RobotB_PartData>().Extra = PartExtra;
    }
    

}
