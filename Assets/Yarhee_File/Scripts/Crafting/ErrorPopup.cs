using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorPopup : MonoBehaviour
{

    [SerializeField] public float timer;

    [SerializeField] float reset;


    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        if(timer >= reset)
        {
            timer = 0;
            gameObject.SetActive(false);
        }
    }
}
