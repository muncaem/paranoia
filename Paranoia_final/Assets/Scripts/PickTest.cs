using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickTest : MonoBehaviour
{
    public GameObject slot; //슬롯의 이미지인걸 어케 알려주지
    public Sprite myImage; //바꿀 이미지

    // Start is called before the first frame update
    void Start()
    {
        slot = GameObject.Find("Slot");
        //Image slotimg = slot.GetComponent<Image>();
    }

    public void Inven()
    {
        myImage = GameObject.Find("btnCloth").GetComponent<Sprite>();
        slot.GetComponent<Image>().sprite = myImage;
    }
    // Update is called once per frame
    void Update()
    {
        Inven();
    }
}
