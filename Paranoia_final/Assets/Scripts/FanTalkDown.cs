using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FanTalkDown : MonoBehaviour
{
    public void FanPanelDown()
    {
        GameObject.Find("Panel").SetActive(false);     //대화창 비활
        GameObject.Find("BgImage").SetActive(false);    //본인버튼 비활
    }

    public void MoveScene()
    {
        if (GameObject.Find("Panel") == null)
        {
            SceneManager.LoadScene("FanDetail");
        }
    }
}
