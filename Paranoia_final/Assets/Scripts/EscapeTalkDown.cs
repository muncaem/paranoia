using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeTalkDown : MonoBehaviour
{
    public void Down()
    {
        GameObject.Find("Panel").SetActive(false);     //��ȭâ ��Ȱ
        GameObject.Find("BtnNext").SetActive(false);    //���ι�ư ��Ȱ
    }
}
