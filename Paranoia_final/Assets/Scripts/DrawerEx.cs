using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawerEx : MonoBehaviour
{
    public GameObject drawer;
    public GameObject drPW;
    public GameObject d1;
    public GameObject d2;
    public GameObject d3;
    public GameObject chart;
    public GameObject knife;
    public GameObject scripts;

    public Text scriptText;

    //bool isdrawerPW = false;

    GameObject gmObj;
    GameManager gm;

    void Start()
    {
        gmObj = GameObject.Find("GameMng");
        gm = gmObj.GetComponent<GameManager>();
    }

    public void DrawerExpansion()
    {
        drawer.SetActive(true);
    }
    public void DrawerClose()
    {
        drawer.SetActive(false);
    }
    public void DrPWExpansion()
    {
        if(gm.isDrawerPwOpen == true)
        {
            //scripts.SetActive(true);
            //scriptText.text = "잠금은 이미 풀린 상태다.";
            d1.SetActive(true);
        }
        else
            drPW.SetActive(true);
    }
    public void DrPWClose()
    {
        drPW.SetActive(false);
    }
    public void D1Expansion()
    {
        if(gm.isDrawerPwOpen == true)
        {
            d1.SetActive(true);
        }
        else
        {
            scripts.SetActive(true);
            scriptText.text = "서랍의 잠금장치를 풀어야 열 수 있을 것 같다.";
        }
    }
    public void D1Close()
    {
        d1.SetActive(false);
    }
    public void D2Expansion()
    {
        if(gm.isDrawerPwOpen == true)
        {
            d2.SetActive(true);
        }
        else
        {
            scripts.SetActive(true);
            scriptText.text = "서랍의 잠금장치를 풀어야 열 수 있을 것 같다.";
        }
    }
    public void D2Close()
    {
        d2.SetActive(false);
    }
    public void D3Expansion()
    {
        if (gm.isDrawerPwOpen == true)
        {
            d3.SetActive(true);
        }
        else
        {
            scripts.SetActive(true);
            scriptText.text = "서랍의 잠금장치를 풀어야 열 수 있을 것 같다.";
        }
    }
    public void D3Close()
    {
        d3.SetActive(false);
    }
    public void ChartEx()
    {
        chart.SetActive(true);
    }
    public void ChartClose()
    {
        chart.SetActive(false);
    }

    public void KnifeEx()
    {
        knife.SetActive(true);
    }
    public void KnifeClose()
    {
        knife.SetActive(false);
    }

    //public void GetKey()
    //{
    //    gm.haveKey = true;
    //}

    // 잠금장치
    //public void DrPWCollect()
    //{
    //    drPW.SetActive(false);
    //    isdrawerPW = true;
    //    scripts.SetActive(true);
    //    scriptText.text = "잠금이 풀렸다!";
    //}



}
