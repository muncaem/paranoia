using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FanTalkDown : MonoBehaviour
{
    public void FanPanelDown()
    {
        GameObject.Find("Panel").SetActive(false);     //��ȭâ ��Ȱ
        GameObject.Find("BgImage").SetActive(false);    //���ι�ư ��Ȱ
    }

    public void MoveScene()
    {
        if (GameObject.Find("Panel") == null)
        {
            SceneManager.LoadScene("FanDetail");
        }
    }
}
