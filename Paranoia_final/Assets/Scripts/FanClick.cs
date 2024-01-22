using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanClick : MonoBehaviour
{
    public void FanBtnClick()
    {
        GameObject talk = GameObject.Find("Panel");     //패널올리고
        talk.transform.position = new Vector3(talk.transform.position.x, 
            talk.transform.position.y + 300);
        GameObject btn = GameObject.Find("BtnNext");    //버튼올리고
        btn.transform.position = new Vector3(btn.transform.position.x,
            btn.transform.position.y + 300);

        //GameObject.Find("BtnEsc").SetActive(false);     //환풍기버튼 비활
    }
}
