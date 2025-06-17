using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotB_PartSelection : MonoBehaviour
{
    [SerializeField] GameObject headmenu;

    [SerializeField] GameObject eyesmenu;


    public void openHeadmenu()
    {
        headmenu.SetActive(true);
        eyesmenu.SetActive(false);
    }

    public void openEyesmenu()
    {
        headmenu.SetActive(false);
        eyesmenu.SetActive(true);
    }

}
