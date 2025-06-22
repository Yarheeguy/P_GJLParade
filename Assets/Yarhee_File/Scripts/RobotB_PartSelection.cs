using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotB_PartSelection : MonoBehaviour
{
    [SerializeField] GameObject headmenu;

    [SerializeField] GameObject eyesmenu;

    [SerializeField] GameObject chestmenu;

    [SerializeField] GameObject armsmenu;

    [SerializeField] GameObject legsmenu;


    public void openHeadmenu()
    {
        headmenu.SetActive(true);
        eyesmenu.SetActive(false);
        chestmenu.SetActive(false);
        armsmenu.SetActive(false);
        legsmenu.SetActive(false);
    }

    public void openEyesmenu()
    {
        headmenu.SetActive(false);
        eyesmenu.SetActive(true);
        chestmenu.SetActive(false);
        armsmenu.SetActive(false);
        legsmenu.SetActive(false);
    }

    public void openChestmenu()
    {
        headmenu.SetActive(false);
        eyesmenu.SetActive(false);
        chestmenu.SetActive(true);
        armsmenu.SetActive(false);
        legsmenu.SetActive(false);
    }

    public void openArmsmenu()
    {
        headmenu.SetActive(false);
        eyesmenu.SetActive(false);
        chestmenu.SetActive(false);
        armsmenu.SetActive(true);
        legsmenu.SetActive(false);
    }

    public void openLegsmenu()
    {
        headmenu.SetActive(false);
        eyesmenu.SetActive(false);
        chestmenu.SetActive(false);
        armsmenu.SetActive(false);
        legsmenu.SetActive(true);
    }

}
