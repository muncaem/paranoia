using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoTalkDown : MonoBehaviour
{
    public void keyPanelDown()
    {
        GameObject.Find("MemoTalk").SetActive(false);      //��ȭâ ��Ȱ
        GameObject.Find("MemoBtnNext").SetActive(false);    //���ι�ư ��Ȱ
    }
}
