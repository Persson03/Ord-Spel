using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    bool Changing = false;
    bool ChangingDone = false;

    [SerializeField] GameObject Done;
    [SerializeField] Text Setting;
    public KeyCode setting;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Changing == true)
        {
            foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKey(kcode) && kcode != KeyCode.Mouse1 && kcode != KeyCode.Mouse0)
                {
                    setting = kcode;
                    Changing = false;
                    Done.gameObject.SetActive(true);
                }
            }
        }
        if (ChangingDone == true)
        {
            Setting.text = setting.ToString();
        }
        Debug.Log(Changing);
    }

    public void PlayerSettings()
    {
        Changing = true;

        
    }

    public void SettingsDone()
    {
        ChangingDone = true;
        Debug.Log(ChangingDone);
        Done.gameObject.SetActive(false);
    }
}
