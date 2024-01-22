using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryCtrl : MonoBehaviour, IPointerClickHandler
{
    //public GameObject itemS;     // ������
    public GameObject itemSlot1;     // ������ �̹���
    public GameObject itemSlot2;     // ������ �̹���
    public GameObject itemSlot3;     // ������ �̹���
    public GameObject itemSlot4;     // ������ �̹���
    public GameObject itemSlot5;     // ������ �̹���

    public GameObject InvenC1;     // ������ ���� �� ����
    public GameObject InvenC2;     // ������ ���� �� ����
    public GameObject InvenC3;     // ������ ���� �� ����
    public GameObject InvenC4;     // ������ ���� �� ����
    public GameObject InvenC5;     // ������ ���� �� ����

    GameObject gmObj;
    GameManager gm;

    bool isChoiced = false;

    public GameObject icObj;
    ItemCtrl ic;

    void Start()
    {
        gmObj = GameObject.Find("GameMng");
        gm = gmObj.GetComponent<GameManager>();

        ic = icObj.GetComponent<ItemCtrl>();
    }

    void Update()
    {
        RectTransform rectTr = itemSlot1.GetComponent<RectTransform>();

        if (gm.isOpened == true && gm.itemCount == 1)
        {
            ic.haveItem = false;
            itemSlot1.SetActive(false);
            InvenC1.SetActive(false);
            gm.itemCount--;
        }
        else if (gm.isOpened == true && gm.itemCount == 2)
        {
            ic.haveItem = false;
            itemSlot2.SetActive(false);
            InvenC2.SetActive(false);
            gm.itemCount--;
        }
        else if (gm.isOpened == true && gm.itemCount == 3)
        {
            ic.haveItem = false;
            itemSlot3.SetActive(false);
            InvenC3.SetActive(false);
            gm.itemCount--;
        }
        else if (gm.isOpened == true && gm.itemCount == 4)
        {
            ic.haveItem = false;
            itemSlot4.SetActive(false);
            InvenC4.SetActive(false);
            gm.itemCount--;
        }
        else if (gm.isOpened == true && gm.itemCount == 5)
        {
            ic.haveItem = false;
            itemSlot5.SetActive(false);
            InvenC5.SetActive(false);
            gm.itemCount--;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (gm.isOpened == false)
        {
            if (isChoiced == false)
            {
                isChoiced = true;
                gm.haveKey = true;
                InvenC1.SetActive(true);
            }

            else
            {
                isChoiced = false;
                gm.haveKey = false;
                InvenC1.SetActive(false);
            }
        }
    }
}
