using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOTOROOM3 : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Main"); // 창고 이름
    }
}
