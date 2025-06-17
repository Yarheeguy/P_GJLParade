using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotB_SelectPart : MonoBehaviour
{
    [SerializeField] GameObject part;

    [SerializeField] Sprite partsprite;

    public void changepart()
    {
        part.GetComponent<SpriteRenderer>().sprite = partsprite;
    }
    

}
