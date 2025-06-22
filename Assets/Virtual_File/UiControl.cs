using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class UiControl : MonoBehaviour
{
    public GameObject zoneui;
    public GameObject Menu;
    public bool active = false;
    public bool paused = false;
    public Teleport teleport;
    public GameObject[] buttons;
    public bool delayed=false;
    public float menuDelay = 0.5f;
    public float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Delay();

        if(Input.GetKeyDown(KeyCode.Escape) && !active &&!paused&&!delayed&& !teleport.teleporting)
        {

            MmOpen();
        }
        if (Input.GetKeyDown(KeyCode.Escape) && paused&&!delayed)
        {
            MmClose();
        }
        if (Input.GetKeyDown(KeyCode.Escape) && active)
        {
            Close();
        }
        for (int i = 0; i<buttons.Length; i++)
        {
            if (i == teleport.zoneID)
            {
                buttons[i].SetActive(false);
            }
            else
            {
                buttons[i].SetActive(true);
            }
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
    public void MmOpen()
    {
        Menu.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
        delayed = true;
    }
    public void MmClose()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
        delayed = true;
    }
    public void SceneSwitch()
    {
        SaveSystem.Save();
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
        Close();
    }
    public void Delay()
    { 
        if(delayed)
        {
            time += Time.unscaledDeltaTime;
            if (time > menuDelay)
            {
                delayed = false;
                time = 0f;
            }
        }
    }
}
