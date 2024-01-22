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
            scriptText.text = "�������� ���� ���ȴ�.\nå���� ���� �������� ����";
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
            scriptText.text = "���谡 �־�� �� �� ���� �� ����.";
        }
    }

    public void SeeCloth()
    {
        gm.cScript = true;
        scripts.SetActive(true);
        scriptBg.SetActive(false);
        cloth.SetActive(true);
        gm.cNext.SetActive(false);
        scriptText.text = "�ǻ� �����̴�. ���� �ָӴ� �ȿ� ���� �ִ� ���ϴ�.";
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
        scriptText.text = "���߸� ���� �հ����̴�.\n�հ������� ��ݡ� ��� �����ִ�.";
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
        scriptText.text = "�ɸ��а� ������ å���̴�.";
    }

    public void SeeBlack()
    {
        scripts.SetActive(true);
        //blackblack.SetActive(true);
        scriptText.text = "���� ��Һ�����. ���. å���� �������� ���⼭ ��Ե� �� ����.";
    }
}
