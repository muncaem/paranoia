using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTalkDown : MonoBehaviour
{
    public void keyPanelDown()
    {
        GameObject.Find("Panel").SetActive(false);      //��ȭâ ��Ȱ
        //GameObject.Find("BtnNext").SetActive(false);    //���ι�ư ��Ȱ

        
    }
}
