using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundfollowcam : MonoBehaviour
{


    [SerializeField] GameObject findCam;

    [SerializeField] Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = findCam.transform.position + offset;
    }
}
