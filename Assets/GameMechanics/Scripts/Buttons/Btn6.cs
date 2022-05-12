using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn6 : MonoBehaviour
{
    Buttons buttons;

    // Start is called before the first frame update
    void Start()
    {
        //Get Buttons Script
        buttons = GameObject.Find("Buttons").GetComponent<Buttons>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void enter()
    {
        buttons.CurrentLetter = buttons.BtnLetter6;

    }

    public void exit()
    {
        
    }
}
