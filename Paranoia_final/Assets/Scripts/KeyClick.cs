using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyClick : MonoBehaviour
{
    GameObject gmObj;
    GameMng gm;
    public GameObject talk;

    private void Start()
    {
        gmObj = GameObject.Find("GameMng");
        gm = gmObj.GetComponent<GameMng>();
    }

    public void KeybtnClick()
    {
        talk.SetActive(true);

        gm.x = true;
    }
}
