using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanClick : MonoBehaviour
{
    public void FanBtnClick()
    {
        GameObject talk = GameObject.Find("Panel");     //�гοø���
        talk.transform.position = new Vector3(talk.transform.position.x, 
            talk.transform.position.y + 300);
        GameObject btn = GameObject.Find("BtnNext");    //��ư�ø���
        btn.transform.position = new Vector3(btn.transform.position.x,
            btn.transform.position.y + 300);

        //GameObject.Find("BtnEsc").SetActive(false);     //ȯǳ���ư ��Ȱ
    }
}
