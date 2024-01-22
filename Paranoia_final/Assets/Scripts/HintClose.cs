using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintClose : MonoBehaviour
{
    public GameObject hint;
    public GameObject set;

    public void ClosePanel()
    {
        hint.SetActive(false);
    }

    public void talkdown()
    {
        hint.SetActive(false);
        set.SetActive(false);
    }
}
