using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHint : MonoBehaviour
{
    public void MovePanel()
    {
        GameObject hint = GameObject.Find("HintTalk");
        hint.transform.position = new Vector3(hint.transform.position.x - 1726, hint.transform.position.y);
        GameObject close = GameObject.Find("HintClose");
        close.transform.position = new Vector3(close.transform.position.x - 1726, close.transform.position.y);
    }
}
