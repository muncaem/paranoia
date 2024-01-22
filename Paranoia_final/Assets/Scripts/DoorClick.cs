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
        //if �κ��� ������ ������ �ٸ� ��ȭ �г� �ø���
        //else �κ��� ������ ������ �Ʒ� ����
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
