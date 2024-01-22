using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDialogue : MonoBehaviour
{
    [SerializeField]
    public Dialogue dialogue;

    private EndingScript theDM;

    // Start is called before the first frame update
    void Start()
    {
        theDM = FindObjectOfType<EndingScript>();
    }

    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(Input.GetMouseButton(0))
        {
            theDM.ShowDialogue(dialogue);
            print("2");
        }
    }
    */

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            theDM.ShowDialogue(dialogue);


            //ExitDialogue();

        }

    }
}
