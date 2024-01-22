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
            scriptText.text = "잠금은 이미 풀린 상태다.";
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

    // 잠금장치
    //public void DoorPWCollect()
    //{
    //    doorPW.SetActive(false);
    //    isdoorPW = true;
    //    scripts.SetActive(true);
    //    scriptText.text = "잠금이 풀렸다!";
    //}

    //public void DoorEscape()
    //{
    //    if(isdoorPW == true)
    //    {
    //        scripts.SetActive(true);
    //        scriptText.text = "병원을 탈출했다.";
    //    }
    //    else
    //    {
    //        scripts.SetActive(true);
    //        scriptText.text = "문의 잠금장치를 풀어야 열 수 있을 것 같다.";
    //    }
    //}
}
