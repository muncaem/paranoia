using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothTalkDown : MonoBehaviour
{
    public void keyPanelDown()
    {
        GameObject.Find("ClothTalk").SetActive(false);      //��ȭâ ��Ȱ
        //GameObject.Find("ClothBtnNext").SetActive(false);    //���ι�ư ��Ȱ
        GameObject.Find("cloth").SetActive(false);       //�� ��ư ��Ȱ
        GameObject.Find("BgImage").SetActive(false);
    }
}
