using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoTalkDown : MonoBehaviour
{
    public void keyPanelDown()
    {
        GameObject.Find("MemoTalk").SetActive(false);      //대화창 비활
        GameObject.Find("MemoBtnNext").SetActive(false);    //본인버튼 비활
    }
}
