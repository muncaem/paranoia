using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstStageOut : MonoBehaviour
{
    public void MoveScene()
    {
        if(GameObject.Find("Panel") == null)
        {
            SceneManager.LoadScene("Room2");
        }
    }
}
