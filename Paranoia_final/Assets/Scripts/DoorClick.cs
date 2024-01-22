using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorClick : MonoBehaviour
{
    public GameObject ot;
    public GameObject back;
    public GameObject talk;

    public void DoorbtnClick()
    {
        //if 인벤에 젓가락 있으면 다른 대화 패널 올리고
        //else 인벤에 젓가락 없으면 아래 실행
        if(GameObject.Find("SlotImage") != null)
        {
            ot.SetActive(true);
            back.SetActive(true);
        }

        else
        {
            back.SetActive(true);
            talk.SetActive(true);
        }
    }
}
