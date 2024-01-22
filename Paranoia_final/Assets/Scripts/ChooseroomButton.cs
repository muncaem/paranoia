using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseroomButton : MonoBehaviour
{
    public GameObject gameobject1;

    // Start is called before the first frame update
    void Start()
    {
        gameobject1.SetActive(true);
    }

    public void onDangjiksil()
    {
        gameobject1.SetActive(false);
    }

    public void onroom3()
    {
        gameobject1.SetActive(false);
    }

    public void onroom4()
    {
        gameobject1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
