using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosetEx : MonoBehaviour
{
    public GameObject closet;
    public GameObject closetIn;
    public GameObject cloth;
    public GameObject finger;
    public GameObject scripts;
    public GameObject scriptBg;
    //public GameObject blackblack;
    //public GameObject bookbook;

    public GameObject doorClosed;
    public GameObject doorOpened;
    

    //bool isFirstOpen = true;

    public Text scriptText;

    GameObject gmObj;
    GameManager gm;

    void Start()
    {
        gmObj = GameObject.Find("GameMng");
        gm = gmObj.GetComponent<GameManager>();
    }

    public void ClosetExpansion()
    {
        closet.SetActive(true);
    }
    public void ClosetClose()
    {
        closet.SetActive(false);
        cloth.SetActive(false);
        finger.SetActive(false);
    }

    public void ClosetOpen()
    {
        //if (gm.haveKey == true && isFirstOpen == true)
        if (gm.haveKey == true)
        {
            scripts.SetActive(true);
            scriptText.text = "수납장의 문이 열렸다.\n책장을 열자 썩은내가 난다";
            gm.isOpened = true;
            //isFirstOpen = false;
            closetIn.SetActive(true);
        }
        //else if (gm.haveKey == true && isFirstOpen == false)
        //{
        //    closetIn.SetActive(true);
        //}
        else
        {
            scripts.SetActive(true);
            scriptText.text = "열쇠가 있어야 열 수 있을 것 같다.";
        }
    }

    public void SeeCloth()
    {
        gm.cScript = true;
        scripts.SetActive(true);
        scriptBg.SetActive(false);
        cloth.SetActive(true);
        gm.cNext.SetActive(false);
        scriptText.text = "의사 가운이다. 가운 주머니 안에 무언가 있는 듯하다.";
    }

    public void ClothClose()
    {
        cloth.SetActive(false);
        gm.cNext.SetActive(false);
    }

    public void SeeFinger()
    {
        gm.fScript = true;
        scripts.SetActive(true);
        scriptBg.SetActive(false);
        finger.SetActive(true);
        //gm.fNext.SetActive(false);
        scriptText.text = "…잘린 검지 손가락이다.\n손가락에는 ▽◎□ 라고 적혀있다.";
    }

    //public void FingerClose()
    //{
    //    finger.SetActive(false);
    //    //gm.fNext.SetActive(false);
    //}

    public void SeeBooks()
    {
        scripts.SetActive(true);
        //bookbook.SetActive(true);
        scriptText.text = "심리학과 관련한 책들이다.";
    }

    public void SeeBlack()
    {
        scripts.SetActive(true);
        //blackblack.SetActive(true);
        scriptText.text = "검은 비닐봉지다. 우욱…. 책장의 썩은내는 여기서 비롯된 것 같다.";
    }
}
