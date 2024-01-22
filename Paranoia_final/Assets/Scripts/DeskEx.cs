using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskEx : MonoBehaviour
{
    public GameObject desk;
    public GameObject cal;

    GameObject gmObj;
    GameManager gm;

    void Start()
    {
        gmObj = GameObject.Find("GameMng");
        gm = gmObj.GetComponent<GameManager>();
    }

    public void DeskExpansion()
    {
        desk.SetActive(true);
    }
    public void DeskClose()
    {
        desk.SetActive(false);
    }
    public void CalExpansion()
    {
        cal.SetActive(true);
    }
    public void CalClose()
    {
        cal.SetActive(false);
    }
}
