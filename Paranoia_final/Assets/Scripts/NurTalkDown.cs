using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NurTalkDown : MonoBehaviour
{
    public void keyPanelDown()
    {
        GameObject.Find("NurcabTalk").SetActive(false);      //��ȭâ ��Ȱ
        GameObject.Find("BgImage").SetActive(false);    //���ι�ư ��Ȱ
    }
}
