using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteTalkDown : MonoBehaviour
{
    public GameObject x;
    public void keyPanelDown()
    {
        x.SetActive(true);

        GameObject.Find("NoteTalk").SetActive(false);      //��ȭâ ��Ȱ
        GameObject.Find("BgImage").SetActive(false);    //���ι�ư ��Ȱ
    }
}
