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

    string CurrentSetting;

    [SerializeField] GameObject Done;
    [SerializeField] Text SubmitSettingText;
    [SerializeField] Text StatusText;
    [SerializeField] Text RemoveSettingText;
    public KeyCode setting = KeyCode.Space;
    // Start is called before the first frame update
    void Start()
    {
        //Deafult Setting For Submitting Guess
        PlayerPrefs.SetString("SubmitSetting", "Mouse1");
        SubmitSettingText.text = "Mouse1";

        PlayerPrefs.SetString("RemoveSetting", "Backspace");
        RemoveSettingText.text = ("Backspace");

        StatusText.gameObject.SetActive(false);
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
                    Done.gameObject.SetActive(true);
                    StatusText.text = setting.ToString();
                }
            }
        }
        if (ChangingDone == true)
        {
            if (CurrentSetting == "SubmitSetting")
            {
                SubmitSettingText.text = setting.ToString();
                PlayerPrefs.SetString("SubmitSetting", setting.ToString());
            }
            else if (CurrentSetting == "RemoveSetting")
            {
                RemoveSettingText.text = setting.ToString();
                PlayerPrefs.SetString("RemoveSetting", setting.ToString());
            }
            ChangingDone = false;

        }
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
        Done.gameObject.SetActive(false);
        StatusText.gameObject.SetActive(false);
        StatusText.text = "Tryck på knappen du vill använda";
        EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(null);
    }

    public void RemoveSetting()
    {
        CurrentSetting = "RemoveSetting";
    }

    public void SubmitSetting()
    {
        CurrentSetting = "SubmitSetting";
    }

    public void ClearSetting()
    {
        CurrentSetting = null;
    }
}
