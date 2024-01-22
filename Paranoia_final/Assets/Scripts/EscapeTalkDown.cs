using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeTalkDown : MonoBehaviour
{
    public void Down()
    {
        GameObject.Find("Panel").SetActive(false);     //대화창 비활
        GameObject.Find("BtnNext").SetActive(false);    //본인버튼 비활
    }
}
