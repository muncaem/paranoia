using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMain : MonoBehaviour
{
    public void MoveScene()
    {
        if (GameObject.Find("ClothTalk") || GameObject.Find("Panel") == null)
        {
            SceneManager.LoadScene("Main");
        }
    }
}
