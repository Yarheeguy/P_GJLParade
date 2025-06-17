using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockingAreas : MonoBehaviour
{
    public GameObject[] Areas;
    public struct Area
    {
        public int requiredIron;
        public int requiredCopper;
        public int requiredGold;
        public int requiredGems;
        public bool isUnlocked;
    }
    // Start is called before the first frame update
    void Start()
    {
        Area[] areas = new Area[5];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
