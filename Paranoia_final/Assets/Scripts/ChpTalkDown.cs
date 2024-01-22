using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChpTalkDown : MonoBehaviour
{
    public GameObject fail;
    public void CpPanelDown()
    {
        fail.SetActive(true);
    }

    public void pandown()
    {
        GameObject.Find("Panel1").SetActive(false);
        GameObject.Find("BgImage").SetActive(false);
    }
}
