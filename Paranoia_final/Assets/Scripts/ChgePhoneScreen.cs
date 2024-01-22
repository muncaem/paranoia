using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChgePhoneScreen : MonoBehaviour
{
    public GameObject page;
    public GameObject back;

    public void btnClick()
    {
        page.SetActive(true);
        back.SetActive(false);
    }

    public void behind()
    {
        page.SetActive(false);
        back.SetActive(true);
    }
}
