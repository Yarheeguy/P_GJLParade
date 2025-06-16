using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiControl : MonoBehaviour
{
    public GameObject zoneui;
    public bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape) && active)
        {
            Close();
        }
    }
    public void Open()
    {
       zoneui.SetActive(true);
        active = true;

    }
    public void Close()
    {

        zoneui.SetActive(false);
        active = false;
    }
}
