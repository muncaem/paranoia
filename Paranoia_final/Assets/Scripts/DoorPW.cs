using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorPW : MonoBehaviour
{
    string pw1 = "-";
    string pw2 = "-";
    string pw3 = "-";
    string pw4 = "-";
    public string pwInput;

    public GameObject scripts;
    public Text scriptText;

    GameObject gmObj;
    GameManager gm;

    void Start()
    {
        gmObj = GameObject.Find("GameMng");
        gm = gmObj.GetComponent<GameManager>();
    }

    private void Update()
    {
        pwInput = pw1 + pw2 + pw3 + pw4;
    }

    public void ButtonCircle()
    {
        if (pw1 == "-")
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
            scriptText.text = "비밀번호는 4자리다.";
            pw1 = "-";
            pw2 = "-";
            pw3 = "-";
            pw4 = "-";
        }
    }
    public void ButtonTriangle()
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
            scriptText.text = "비밀번호는 4자리다.";
            pw1 = "-";
            pw2 = "-";
            pw3 = "-";
            pw4 = "-";
        }
    }
    public void ButtonSquare()
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
            scriptText.text = "비밀번호는 4자리다.";
            pw1 = "-";
            pw2 = "-";
            pw3 = "-";
            pw4 = "-";
        }
    }

    public void ButtonOK()
    {
        if (pwInput == "3112")
        {
            scripts.SetActive(true);
            scriptText.text = "병원을 탈출했다.";
            gm.isDoorPwOpen = true;
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
