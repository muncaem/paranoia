using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int itemCount = 0;   // 아이템 개수
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
        // 메뉴 창 열기
        gameMenu.SetActive(true);
    }

    public void CloseMenu()
    {
        // 메뉴 창 닫기
        gameMenu.SetActive(false);
    }

    public void OpenHint()
    {
        // 힌트 창 열기
        gameHint.SetActive(true);
        if(isDrawerPwOpen == false)
        {
            hintScr.text = "달력을 통해 일정이 있는 날짜와 요일을 꼼꼼하게 확인하자.";
        }
        else if (isDrawerPwOpen == true && isOpened == false)
        {
            hintScr.text = "서랍에 있는 수납장 열쇠 잊지 말기!";
        }
        else
        {
            hintScr.text = "세상 일이란 종종 뒤집거나 분리하여 보아야 한다.";
        }
    }

    public void CloseHint()
    {
        // 힌트 창 닫기
        gameHint.SetActive(false);
    }

    public void ReturnMain()
    {
        // 메인으로 돌아가기
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        // 게임 시작
        SceneManager.LoadScene(1);
    }

    public void OpenMethod()
    {
        // 방법 설명창 열기
        gameMethod.SetActive(true);
    }

    public void CloseMethod()
    {
        // 방법 설명창 닫기
        gameMethod.SetActive(false);
    }

    public void QuitGame()
    {
        // 게임 종료
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
