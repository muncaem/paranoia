using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemobtnClick : MonoBehaviour
{
    public void btnClick()
    {
        GameObject talk = GameObject.Find("MemoTalk");     //�гοø���
        talk.transform.position = new Vector3(talk.transform.position.x,
            talk.transform.position.y + 300);
        GameObject btn = GameObject.Find("MemoBtnNext");    //��ư�ø���
        btn.transform.position = new Vector3(btn.transform.position.x,
            btn.transform.position.y + 300);
    }
}
