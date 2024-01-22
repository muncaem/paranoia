using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothTalkDown : MonoBehaviour
{
    public void keyPanelDown()
    {
        GameObject.Find("ClothTalk").SetActive(false);      //대화창 비활
        //GameObject.Find("ClothBtnNext").SetActive(false);    //본인버튼 비활
        GameObject.Find("cloth").SetActive(false);       //옷 버튼 비활
        GameObject.Find("BgImage").SetActive(false);
    }
}
