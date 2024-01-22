using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryNextBtn : MonoBehaviour
{
    //private GameObject talk;
    //private GameObject diary;

    public GameObject x;

    public void NextBtn()
    {
        //GameObject.Find("TalkCanvas").SetActive(true);
        GameObject.Find("DiaryCanvas").SetActive(false);
        GameObject.Find("BtnNext").SetActive(false);

        x.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
