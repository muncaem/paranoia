using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothClick : MonoBehaviour
{
    public void btnClick()
    {
        GameObject talk = GameObject.Find("ClothTalk");     //패널올리고
        talk.transform.position = new Vector3(talk.transform.position.x,
            talk.transform.position.y + 300);
        GameObject btn = GameObject.Find("ClothBtnNext");    //버튼올리고
        btn.transform.position = new Vector3(btn.transform.position.x,
            btn.transform.position.y + 300);
        //GameObject.Find("btnCloth").SetActive(false);
    }
}
