using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ROOM4WARNING : MonoBehaviour
{
    public GameObject room4;
    public Button btn3;


    // Start is called before the first frame update
    void Start()
    {
        room4.SetActive(false);

        btn3.onClick.AddListener(Showroom4);
    }

    void Showroom4()
    {
        room4.SetActive(true);
        Invoke("Hideroom4", 2);
    }

    void Hideroom4()
    {
        room4.SetActive(false);
    }
}
