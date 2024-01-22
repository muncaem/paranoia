using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOTOCHOOSEROOM : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Choose Room"); // 창고 이름
    }
}
