using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BI : MonoBehaviour
{
    public Load load;
    public Button[] headP;
    public Button[] bodyP;
    public Button[] legsP;
    public Button[] eyesP;
    public Button[] armsP;
    int x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=1; i<5; i++)
        {
            x = i - 1;
            if (load.HeadB[i].interactable == true)
            {
                headP[x].interactable = false;
            }
            else
            {
                headP[x].interactable = true;
            }
            if (load.BodyB[i].interactable == true)
            {
                bodyP[x].interactable = false;
            }
            else
            {
                bodyP[x].interactable = true;
            }
            if (load.LegsB[i].interactable == true)
            {
                legsP[x].interactable = false;
            }
            else
            {
                legsP[x].interactable = true;
            }
            if (load.EyesB[i].interactable == true)
            {
                eyesP[x].interactable = false;
            }
            else
            {
                eyesP[x].interactable = true;
            }
            if (load.ArmsB[i].interactable == true)
            {
                armsP[x].interactable = false;
            }
            else
            {
                armsP[x].interactable = true;
            }
        }
    }
}
