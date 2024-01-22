using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrawerToMain : MonoBehaviour
{
    public void MoveScene()
    {
        GameObject.Find("PhoneCanvas").SetActive(false);
    }
}
