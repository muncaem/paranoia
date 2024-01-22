using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTalkDown : MonoBehaviour
{
    public void Down()
    {
        GameObject.Find("Panel2").SetActive(false);     //대화창 비활
        GameObject.Find("BgImage").SetActive(false);    //본인버튼 비활
    }
}
