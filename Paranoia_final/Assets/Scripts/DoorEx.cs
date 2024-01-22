using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorEx : MonoBehaviour
{
    public GameObject door;
    public GameObject doorPW;
    public GameObject scripts;

    public Text scriptText;

    //bool isdoorPW = false;

    GameObject gmObj;
    GameManager gm;

    void Start()
    {
        gmObj = GameObject.Find("GameMng");
        gm = gmObj.GetComponent<GameManager>();
    }

    public void DoorExpansion()
    {
        if (gm.isDoorPwOpen == true)
        {
            scripts.SetActive(true);
            scriptText.text = "����� �̹� Ǯ�� ���´�.";
        }
        else
            door.SetActive(true);
    }
    public void DoorClose()
    {
        door.SetActive(false);
    }

    public void DoorPWExpansion()
    {
        doorPW.SetActive(true);
    }
    public void DoorPWClose()
    {
        doorPW.SetActive(false);
    }

    // �����ġ
    //public void DoorPWCollect()
    //{
    //    doorPW.SetActive(false);
    //    isdoorPW = true;
    //    scripts.SetActive(true);
    //    scriptText.text = "����� Ǯ�ȴ�!";
    //}

    //public void DoorEscape()
    //{
    //    if(isdoorPW == true)
    //    {
    //        scripts.SetActive(true);
    //        scriptText.text = "������ Ż���ߴ�.";
    //    }
    //    else
    //    {
    //        scripts.SetActive(true);
    //        scriptText.text = "���� �����ġ�� Ǯ��� �� �� ���� �� ����.";
    //    }
    //}
}
