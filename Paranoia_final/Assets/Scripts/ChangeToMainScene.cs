using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeToMainScene : MonoBehaviour
{
    public void ChangeSceneBtn()
    {
        if(GameObject.Find("DiaryCanvas") == null)
        {
            SceneManager.LoadScene("Scene2");
        }
        //switch (this.gameObject.name)
        //{
        //    case "BtnEsc":
        //        SceneManager.LoadScene("Scene3");
        //        break;
        //}
    }
}
