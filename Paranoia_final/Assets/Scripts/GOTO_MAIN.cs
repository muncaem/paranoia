using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GOTO_MAIN : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("GameMain");
    }
}
