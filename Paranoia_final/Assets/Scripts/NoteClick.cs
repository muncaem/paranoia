using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteClick : MonoBehaviour
{
    public void btnClick()
    {
        GameObject talk = GameObject.Find("NoteTalk");     //�гοø���
        talk.transform.position = new Vector3(talk.transform.position.x,
            talk.transform.position.y + 300);
        GameObject btn = GameObject.Find("NoteBtnNext");    //��ư�ø���
        btn.transform.position = new Vector3(btn.transform.position.x,
            btn.transform.position.y + 300);
    }
}
