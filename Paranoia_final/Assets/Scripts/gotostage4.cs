using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotostage4 : MonoBehaviour
{
    GameObject gmObj;
    GameMng gm;
    public GameObject ttfpw;

    private void Start()
    {
        gmObj = GameObject.Find("GameMng");
        gm = gmObj.GetComponent<GameMng>();
    }

    public void go4()
    {
        ttfpw.SetActive(true);
    }
}
