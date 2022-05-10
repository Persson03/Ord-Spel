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
    [SerializeField] Text StatusText;
    public KeyCode setting = KeyCode.Space;
    // Start is called before the first frame update
    void Start()
    {
        //Deafult Setting For Submitting Guess
        PlayerPrefs.SetString("Setting1", "Mouse1");
        Setting.text = "Mouse1";

        StatusText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(setting.ToString());
        if (Changing == true)
        {
            foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode)))
            {
                if (Input.GetKey(kcode) && kcode != KeyCode.Mouse1 && kcode != KeyCode.Mouse0)
                {
                    setting = kcode;
                    Done.gameObject.SetActive(true);
                    StatusText.text = setting.ToString();
                }
            }
        }
        if (ChangingDone == true)
        {
            Setting.text = setting.ToString();
            PlayerPrefs.SetString("Setting1", setting.ToString());
        }
        Debug.Log(Changing);
    }

    public void PlayerSettings()
    {
        Changing = true;
        Done.gameObject.SetActive(true);
        StatusText.gameObject.SetActive(true);
        EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(null);
    }

    public void SettingsDone()
    {
        ChangingDone = true;
        Changing = false;
        Debug.Log(ChangingDone);
        Done.gameObject.SetActive(false);
        StatusText.gameObject.SetActive(false);
        StatusText.text = "Tryck på knappen du vill använda";
        EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(null);
    }
}
