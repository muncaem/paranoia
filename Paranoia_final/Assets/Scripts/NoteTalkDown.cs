using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteTalkDown : MonoBehaviour
{
    public GameObject x;
    public void keyPanelDown()
    {
        x.SetActive(true);

        GameObject.Find("NoteTalk").SetActive(false);      //대화창 비활
        GameObject.Find("BgImage").SetActive(false);    //본인버튼 비활
    }
}
