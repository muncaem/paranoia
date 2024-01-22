using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("sceneChange", 4);
    }

    void sceneChange()
    {
        SceneManager.LoadScene("Scene2");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
