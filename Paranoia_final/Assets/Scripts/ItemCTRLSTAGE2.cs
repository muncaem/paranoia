using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ItemCTRLSTAGE2 : MonoBehaviour/*, IPointerDownHandler*/, IPointerClickHandler
{
    public bool haveItem;   // 해당 아이템을 가지고 있느냐 없느냐

    public GameObject item;     // 아이템

    public GameObject itemSlot1;     // 아이템 이미지
    public GameObject itemSlot2;     // 아이템 이미지
    public GameObject itemSlot3;     // 아이템 이미지
    public GameObject itemSlot4;     // 아이템 이미지
    public GameObject itemSlot5;     // 아이템 이미지

    //GameMng gm;
    GameObject gmObj;
    GameManager gm;

    //public int itemCount = 0;   // 아이템 개수

    void Start()
    {
        gmObj = GameObject.Find("GameMng");
        gm = gmObj.GetComponent<GameManager>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Destroy(item);
        haveItem = true;
        gm.itemCount++;

        if (haveItem == true)
        {
            if (gm.itemCount == 1)
            {
                itemSlot1.SetActive(true);
            }
            else if (gm.itemCount == 2)
            {
                itemSlot2.SetActive(true);
            }
            else if (gm.itemCount == 3)
            {
                itemSlot3.SetActive(true);
            }
            else if (gm.itemCount == 4)
            {
                itemSlot4.SetActive(true);
            }
            else
            {
                itemSlot5.SetActive(true);
            }
        }
    }
}