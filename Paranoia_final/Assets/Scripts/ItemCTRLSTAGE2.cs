using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ItemCTRLSTAGE2 : MonoBehaviour/*, IPointerDownHandler*/, IPointerClickHandler
{
    public bool haveItem;   // �ش� �������� ������ �ִ��� ������

    public GameObject item;     // ������

    public GameObject itemSlot1;     // ������ �̹���
    public GameObject itemSlot2;     // ������ �̹���
    public GameObject itemSlot3;     // ������ �̹���
    public GameObject itemSlot4;     // ������ �̹���
    public GameObject itemSlot5;     // ������ �̹���

    //GameMng gm;
    GameObject gmObj;
    GameManager gm;

    //public int itemCount = 0;   // ������ ����

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