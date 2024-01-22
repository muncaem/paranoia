using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurTalkDown : MonoBehaviour
{
    public void keyPanelDown()
    {
        GameObject.Find("NurcabTalk").SetActive(false);      //대화창 비활
        GameObject.Find("BgImage").SetActive(false);    //본인버튼 비활
    }
}
