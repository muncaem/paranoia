using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    GameObject cam;
    public GameObject btnR;
    public GameObject btnL;
    public GameObject leftitem;
    public GameObject rightitem;
    // Start is called before the first frame update
    void Start()
    {
        this.cam = GameObject.Find("Main Camera");
        //btnR = GameObject.Find("BtnRight");
        //btnL = GameObject.Find("BtnLeft");
        //btnL.SetActive(false);
        rightitem.SetActive(false);
        btnL.SetActive(false);
        //GameObject.Find("BUICanvas").transform.FindChild("btnL").gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Press(int key)
    {
        Vector3 rectTemp = this.cam.transform.localPosition;

        switch (key)
        {
            case 1: //аб
                rectTemp.x = 0;
                break;
            case 2: //©Л
                rectTemp.x = 17f;
                break;
        }
        this.cam.transform.localPosition = rectTemp;

        if (rectTemp.x == 17f)
        {
            //GameObject.Find("BUICanvas").transform.FindChild("btnL").gameObject.SetActive(true);
            btnL.SetActive(true);
            btnR.SetActive(false);
            leftitem.SetActive(false);
            rightitem.SetActive(true);
        }

        if (rectTemp.x == 0)
        {
            btnR.SetActive(true);
            //GameObject.Find("BUICanvas").transform.FindChild("btnR").gameObject.SetActive(true);
            btnL.SetActive(false);
            rightitem.SetActive(false);
            leftitem.SetActive(true);
        }
    }
}
