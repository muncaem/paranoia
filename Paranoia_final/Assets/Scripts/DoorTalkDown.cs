using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTalkDown : MonoBehaviour
{
    public void Down()
    {
        GameObject.Find("Panel2").SetActive(false);     //��ȭâ ��Ȱ
        GameObject.Find("BgImage").SetActive(false);    //���ι�ư ��Ȱ
    }
}
