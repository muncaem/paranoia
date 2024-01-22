using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawerPW : MonoBehaviour
{
    string pw1 = "-";
    string pw2 = "-";
    string pw3 = "-";
    string pw4 = "-";
    public string pwInput;

    public GameObject scripts;
    public Text scriptText;

    public Text pwNumText;

    GameObject gmObj;
    GameManager gm;

    void Start()
    {
        gmObj = GameObject.Find("GameMng");
        gm = gmObj.GetComponent<GameManager>();
    }

    private void Update()
    {
        pwInput = pw1 + " " + pw2 + " " + pw3 + " " + pw4;
        pwNumText.text = pwInput;
    }

    public void ButtonOne()
    {
        if(pw1 == "-")
            pw1 = "1";
        else if (pw1 != "-" && pw2 == "-")
            pw2 = "1";
        else if (pw1 != "-" && pw2 != "-" && pw3 == "-")
            pw3 = "1";
        else if (pw1 != "-" && pw2 != "-" && pw3 != "-" && pw4 == "-")
            pw4 = "1";
        else
        {
            scripts.SetActive(true);
            scriptText.text = "비밀번호는 4자리 숫자다.";
            pw1 = "-";
            pw2 = "-";
            pw3 = "-";
            pw4 = "-";
        }
    }
    public void ButtonTwo()
    {
        if (pw1 == "-")
            pw1 = "2";
        else if (pw1 != "-" && pw2 == "-")
            pw2 = "2";
        else if (pw1 != "-" && pw2 != "-" && pw3 == "-")
            pw3 = "2";
        else if (pw1 != "-" && pw2 != "-" && pw3 != "-" && pw4 == "-")
            pw4 = "2";
        else
        {
            scripts.SetActive(true);
            scriptText.text = "비밀번호는 4자리 숫자다.";
            pw1 = "-";
            pw2 = "-";
            pw3 = "-";
            pw4 = "-";
        }
    }
    public void ButtonThree()
    {
        if (pw1 == "-")
            pw1 = "3";
        else if (pw1 != "-" && pw2 == "-")
            pw2 = "3";
        else if (pw1 != "-" && pw2 != "-" && pw3 == "-")
            pw3 = "3";
        else if (pw1 != "-" && pw2 != "-" && pw3 != "-" && pw4 == "-")
            pw4 = "3";
        else
        {
            scripts.SetActive(true);
            scriptText.text = "비밀번호는 4자리 숫자다.";
            pw1 = "-";
            pw2 = "-";
            pw3 = "-";
            pw4 = "-";
        }
    }
    public void ButtonFour()
    {
        if (pw1 == "-")
            pw1 = "4";
        else if (pw1 != "-" && pw2 == "-")
            pw2 = "4";
        else if (pw1 != "-" && pw2 != "-" && pw3 == "-")
            pw3 = "4";
        else if (pw1 != "-" && pw2 != "-" && pw3 != "-" && pw4 == "-")
            pw4 = "4";
        else
        {
            scripts.SetActive(true);
            scriptText.text = "비밀번호는 4자리 숫자다.";
            pw1 = "-";
            pw2 = "-";
            pw3 = "-";
            pw4 = "-";
        }
    }
    public void ButtonFive()
    {
        if (pw1 == "-")
            pw1 = "5";
        else if (pw1 != "-" && pw2 == "-")
            pw2 = "5";
        else if (pw1 != "-" && pw2 != "-" && pw3 == "-")
            pw3 = "5";
        else if (pw1 != "-" && pw2 != "-" && pw3 != "-" && pw4 == "-")
            pw4 = "5";
        else
        {
            scripts.SetActive(true);
            scriptText.text = "비밀번호는 4자리 숫자다.";
            pw1 = "-";
            pw2 = "-";
            pw3 = "-";
            pw4 = "-";
        }
    }
    public void ButtonSix()
    {
        if (pw1 == "-")
            pw1 = "6";
        else if (pw1 != "-" && pw2 == "-")
            pw2 = "6";
        else if (pw1 != "-" && pw2 != "-" && pw3 == "-")
            pw3 = "6";
        else if (pw1 != "-" && pw2 != "-" && pw3 != "-" && pw4 == "-")
            pw4 = "6";
        else
        {
            scripts.SetActive(true);
            scriptText.text = "비밀번호는 4자리 숫자다.";
            pw1 = "-";
            pw2 = "-";
            pw3 = "-";
            pw4 = "-";
        }
    }
    public void ButtonSeven()
    {
        if (pw1 == "-")
            pw1 = "7";
        else if (pw1 != "-" && pw2 == "-")
            pw2 = "7";
        else if (pw1 != "-" && pw2 != "-" && pw3 == "-")
            pw3 = "7";
        else if (pw1 != "-" && pw2 != "-" && pw3 != "-" && pw4 == "-")
            pw4 = "7";
        else
        {
            scripts.SetActive(true);
            scriptText.text = "비밀번호는 4자리 숫자다.";
            pw1 = "-";
            pw2 = "-";
            pw3 = "-";
            pw4 = "-";
        }
    }
    public void ButtonEight()
    {
        if (pw1 == "-")
            pw1 = "8";
        else if (pw1 != "-" && pw2 == "-")
            pw2 = "8";
        else if (pw1 != "-" && pw2 != "-" && pw3 == "-")
            pw3 = "8";
        else if (pw1 != "-" && pw2 != "-" && pw3 != "-" && pw4 == "-")
            pw4 = "8";
        else
        {
            scripts.SetActive(true);
            scriptText.text = "비밀번호는 4자리 숫자다.";
            pw1 = "-";
            pw2 = "-";
            pw3 = "-";
            pw4 = "-";
        }
    }
    public void ButtonNine()
    {
        if (pw1 == "-")
            pw1 = "9";
        else if (pw1 != "-" && pw2 == "-")
            pw2 = "9";
        else if (pw1 != "-" && pw2 != "-" && pw3 == "-")
            pw3 = "9";
        else if (pw1 != "-" && pw2 != "-" && pw3 != "-" && pw4 == "-")
            pw4 = "9";
        else
        {
            scripts.SetActive(true);
            scriptText.text = "비밀번호는 4자리 숫자다.";
            pw1 = "-";
            pw2 = "-";
            pw3 = "-";
            pw4 = "-";
        }
    }
    public void ButtonZero()
    {
        if (pw1 == "-")
            pw1 = "0";
        else if (pw1 != "-" && pw2 == "-")
            pw2 = "0";
        else if (pw1 != "-" && pw2 != "-" && pw3 == "-")
            pw3 = "0";
        else if (pw1 != "-" && pw2 != "-" && pw3 != "-" && pw4 == "-")
            pw4 = "0";
        else
        {
            scripts.SetActive(true);
            scriptText.text = "비밀번호는 4자리 숫자다.";
            pw1 = "-";
            pw2 = "-";
            pw3 = "-";
            pw4 = "-";
        }
    }

    public void ButtonStar()
    {
        pw1 = "-";
        pw2 = "-";
        pw3 = "-";
        pw4 = "-";
    }

    public void ButtonSharp()
    {
        if(pwInput == "2 8 2 5")
        {
            scripts.SetActive(true);
            scriptText.text = "잠금이 풀렸다!";
            gm.isDrawerPwOpen = true;
        }
        else
        {
            scripts.SetActive(true);
            scriptText.text = "비밀번호가 틀렸다.";
            pw1 = "-";
            pw2 = "-";
            pw3 = "-";
            pw4 = "-";
        }
    }
}
