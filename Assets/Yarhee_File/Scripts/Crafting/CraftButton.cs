using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftButton : MonoBehaviour
{
    [SerializeField] GameObject findInventory;

    [SerializeField] int Ironprice;
    [SerializeField] int Goldprice;
    [SerializeField] int Copperprice;
    [SerializeField] int Gemprice;

    [SerializeField] GameObject ThinginBuilding;

    [SerializeField] GameObject errortext;



    public void craftitem()
    {
        if(findInventory.GetComponent<Material_Inventory>().iron >= Ironprice && findInventory.GetComponent<Material_Inventory>().gold >= Goldprice && findInventory.GetComponent<Material_Inventory>().copper >= Copperprice && findInventory.GetComponent<Material_Inventory>().gems >= Gemprice)
        {
            findInventory.GetComponent<Material_Inventory>().iron = findInventory.GetComponent<Material_Inventory>().iron - Ironprice;
            findInventory.GetComponent<Material_Inventory>().gold = findInventory.GetComponent<Material_Inventory>().gold - Goldprice;
            findInventory.GetComponent<Material_Inventory>().copper = findInventory.GetComponent<Material_Inventory>().copper - Copperprice;
            findInventory.GetComponent<Material_Inventory>().gems = findInventory.GetComponent<Material_Inventory>().gems - Gemprice;

            gameObject.GetComponent<Button>().interactable = false;
            ThinginBuilding.GetComponent<Button>().interactable = true;

        }
        else
        {
            errortext.SetActive(true);
            errortext.GetComponent<ErrorPopup>().timer = 0;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
