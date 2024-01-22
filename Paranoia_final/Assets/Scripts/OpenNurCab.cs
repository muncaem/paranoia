using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNurCab : MonoBehaviour
{
    public GameObject op;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("keyInv") != null)
        {
            GameObject.Find("closecab").SetActive(false);
            op.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
