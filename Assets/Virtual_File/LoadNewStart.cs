using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewStart : MonoBehaviour
{
    public bool has_save;
    // Start is called before the first frame update
    void Start()
    {
        LoadIN();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveNew()
    {
        bool isNew = true;
        StaticData.isNewGame = isNew;
        SceneManager.LoadScene("Moving Scene");
    }
    public void Load()
    {
        if(has_save)
        {
            bool isNew = false;
            StaticData.isNewGame = isNew;
            SceneManager.LoadScene("Moving Scene");
        }    
        
    }
    public void LoadIN()
    {
        if(File.ReadAllText(Application.persistentDataPath + "/save"+".gmsf")!=null)
        {
            has_save = true;
        }
        else
        {
            has_save = false;
        }
    }
    public void Quit()
    {
        Application.Quit();
    }
}

