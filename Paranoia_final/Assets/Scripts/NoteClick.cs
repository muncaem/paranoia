using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteClick : MonoBehaviour
{
    public void btnClick()
    {
        GameObject talk = GameObject.Find("NoteTalk");     //패널올리고
        talk.transform.position = new Vector3(talk.transform.position.x,
            talk.transform.position.y + 300);
        GameObject btn = GameObject.Find("NoteBtnNext");    //버튼올리고
        btn.transform.position = new Vector3(btn.transform.position.x,
            btn.transform.position.y + 300);
    }
}
