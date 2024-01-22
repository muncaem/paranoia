using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickUp : MonoBehaviour
{
    public Item item;

    //public string DisplaySprite;
    //private GameObject InventorySlots;

    /*
    public void getMouseButtonDown()
    {
        ItemPickUp();
    }
    */

    /*
    private void PickItemUp()
    {
        foreach(Transform slot in InventorySlots.transform)
        {
            if(slot.transform.GetChild(0).GetComponent<Image>().sprite.name == "empty_item")
            {
                slot.transform.GetChild(0).GetComponent<Image>().sprite =
                    Resources.Load<Sprite>("Inventory Items/" + DisplaySprite);
                Destroy(gameObject);
                break;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        InventorySlots = GameObject.Find("Slots");
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PickItemUp();
        }
    }
    */
}
