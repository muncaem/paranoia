using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int itemCount = 0;   // ������ ����
    public bool isOpened = false;
    public bool isDrawerPwOpen = false;
    public bool isDoorPwOpen = false;
    public bool haveKey = false;
    public bool cScript = true;
    public bool fScript = true;

    public GameObject gameMenu;
    public GameObject gameHint;
    public GameObject gameMethod;
    public GameObject drawerLock;
    public GameObject doorLock;
    public GameObject cNext;
    public GameObject finger;

    public GameObject scripts;
    public Text hintScr;

    public void OpenMenu()
    {
        // �޴� â ����
        gameMenu.SetActive(true);
    }

    public void CloseMenu()
    {
        // �޴� â �ݱ�
        gameMenu.SetActive(false);
    }

    public void OpenHint()
    {
        // ��Ʈ â ����
        gameHint.SetActive(true);
        if(isDrawerPwOpen == false)
        {
            hintScr.text = "�޷��� ���� ������ �ִ� ��¥�� ������ �Ĳ��ϰ� Ȯ������.";
        }
        else if (isDrawerPwOpen == true && isOpened == false)
        {
            hintScr.text = "������ �ִ� ������ ���� ���� ����!";
        }
        else
        {
            hintScr.text = "���� ���̶� ���� �����ų� �и��Ͽ� ���ƾ� �Ѵ�.";
        }
    }

    public void CloseHint()
    {
        // ��Ʈ â �ݱ�
        gameHint.SetActive(false);
    }

    public void ReturnMain()
    {
        // �������� ���ư���
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        // ���� ����
        SceneManager.LoadScene(1);
    }

    public void OpenMethod()
    {
        // ��� ����â ����
        gameMethod.SetActive(true);
    }

    public void CloseMethod()
    {
        // ��� ����â �ݱ�
        gameMethod.SetActive(false);
    }

    public void QuitGame()
    {
        // ���� ����
        Application.Quit();
    }
    public void ScriptClose()
    {
        scripts.SetActive(false);
        if(isDrawerPwOpen == true)
        {
            drawerLock.SetActive(false);
        }
        if(cScript == true)
        {
            cNext.SetActive(true);
            cScript = false;
        }
        if (fScript == true)
        {
            finger.SetActive(false);
            fScript = false;
        }
        if (isDoorPwOpen == true)
        {
            SceneManager.LoadScene("Ending");
        }
    }
}
