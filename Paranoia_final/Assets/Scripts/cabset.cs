using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cabset : MonoBehaviour
{
    public GameObject op;
    public GameObject back;
    public GameObject talk;

    public GameObject nurcab;

    public void clickclose()
    {
        if (GameObject.Find("SlotImage") != null && GameObject.Find("InvenC1") == true)
        {
            GameObject.Find("closeCab").SetActive(false);
            op.SetActive(true);
            GameObject.Find("SlotImage").SetActive(false);
            GameObject.Find("InvenC1").SetActive(false);
        }

        else
        {
            talk.SetActive(true);
            back.SetActive(true);
        }
    }

    //public void clickcopen()
    //{
    //    GameObject.Find("SlotImage").SetActive(false);
    //    GameObject.Find("InvenC1").SetActive(false);
    //}

    public void toNurcab()
    {
        //SceneManager.LoadScene("nurcab");
        nurcab.SetActive(true);
    }
}
