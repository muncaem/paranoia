using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopClick : MonoBehaviour
{
    public void ChopBtnClick()
    {
        GameObject talk = GameObject.Find("Panel1");    //�гοø���
        talk.transform.position = new Vector3(talk.transform.position.x, 
            talk.transform.position.y + 300);
        GameObject btn = GameObject.Find("BtnNext1");   //��ư�ø���
        btn.transform.position = new Vector3(btn.transform.position.x,
            btn.transform.position.y + 300);

        //GameObject.Find("BtnChp").SetActive(false);     //��������ư ��Ȱ
    }
}
