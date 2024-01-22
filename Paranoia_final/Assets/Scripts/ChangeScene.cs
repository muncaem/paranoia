using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject memo;
    public GameObject page;
    public void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            

            case "MemoBtnNext":
                //SceneManager.LoadScene("Memo");
                memo.SetActive(true);
                break;

            case "btnMyCab":
                memo.SetActive(true);
                break;

            case "btnDrawer":
                SceneManager.LoadScene("Drawer");
                GameObject.Find("btnDrawer").SetActive(false);
                break;

            case "btnPhone":
                SceneManager.LoadScene("Phone");
                GameObject.Find("btnPhone").SetActive(false);
                break;

            case "btnBack":
                page.SetActive(false);
                //SceneManager.LoadScene("Main");
                break;

            //case "NoteBtnNext":
            //    SceneManager.LoadScene("Note");
            //    break;

            case "btnBackToMain":
                SceneManager.LoadScene("nurcab");
                break;

            case "Diary":
                SceneManager.LoadScene("Diary");
                break;

            case "MainButton":
                SceneManager.LoadScene("GameMain");
                break;
        }
    }
}
