using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSaveStart : MonoBehaviour
{
    public bool isNewGame;
    public void Start()
    {
        isNewGame = StaticData.isNewGame;
        if (isNewGame)
        {
            SaveSystem.Save();
        }
        else
        {
            SaveSystem.Loads();
        }
    }
}
