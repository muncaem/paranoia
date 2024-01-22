using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    private DisplayImage currentDisplay;
    public GameObject gameobject1;
    //public GameObject gameobject2;
    public GameObject gameobject3;
    public GameObject gameobject4;
    public GameObject gameobject5;
    public GameObject gameobject6;
    public GameObject gameObject7;
    public GameObject gameObject8;


    // Start is called before the first frame update
    void Start()
    {
        currentDisplay = GameObject.Find("displayImage").GetComponent<DisplayImage>();
        
        gameobject4.SetActive(false);
        gameobject5.SetActive(false);
        gameobject6.SetActive(false);
        gameObject7.SetActive(false);
        gameObject8.SetActive(false);
        
    }

    public void OnRightClickArrow()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall + 1;
        

        if(gameobject4 != null)
        {
            gameobject4.SetActive(true);
        }

        if (gameobject5 != null)
        {
            gameobject5.SetActive(true);
        }

        if (gameobject6 != null)
        {
            gameobject6.SetActive(true);
        }

        if (gameObject8 != null)
        {
            gameObject8.SetActive(true);
        }

        gameObject7.SetActive(true);
        
        gameobject1.SetActive(false);

        if (gameobject3 != null)
        {
            gameobject3.SetActive(false);
        }
    }

    public void OnLeftClickArrow()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall - 1;
        
        gameobject1.SetActive(true);

        if (gameobject3 != null)
        {
            gameobject3.SetActive(true);
        }

        if (gameobject4 != null)
        {
            gameobject4.SetActive(false);
        }

        if (gameobject5 != null)
        {
            gameobject5.SetActive(false);
        }

        if (gameobject6 != null)
        {
            gameobject6.SetActive(false);
        }

        if (gameObject8 != null)
        {
            gameObject8.SetActive(false);
        }

        gameObject7.SetActive(false);
    }
}
