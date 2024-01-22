using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trashbin : MonoBehaviour
{

    public GameObject trashbin;

    public void OnMouseDown()
    {
        Destroy(trashbin);
    }
}
