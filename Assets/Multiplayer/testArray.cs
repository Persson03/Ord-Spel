using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testArray : MonoBehaviour
{
    private string[] names;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            for (int i = 0; i < names.Length; i++)
            {
                Debug.Log("Name: " + names[i]);
            }
        }
    }

    private void AddName(string name)
    {
        
    }
}
