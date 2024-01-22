using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintClick : MonoBehaviour
{
    public GameObject hint;
    public GameObject set;

    public void hintset()
    {
        hint.SetActive(true);
    }

    public void menuset()
    {
        set.SetActive(true);
    }

    public void opendrawer()
    {
        set.SetActive(true);
        hint.SetActive(false);
    }

    public void talkset()
    {
        set.SetActive(true);
        hint.SetActive(true);
    }
}
