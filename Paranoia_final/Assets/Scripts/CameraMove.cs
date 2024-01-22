using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraMove : MonoBehaviour
{

    public GameObject button;
    public GameObject change;

    public void changeImage()
    {
        change = gameObject.GetComponent<GameObject>();
    }
}
