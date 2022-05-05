using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public delegate void OnVariableChangeDelegate(int newVal);

    [SerializeField] Text countdownText;
    [SerializeField] Animator anim;
    [SerializeField]private float startingTime = 30f;

    [HideInInspector]public float currentTime;

    private string endScreenScene = "EndScreen";
    private bool timerActivated = false;
    private float elapsed = 0f;



    void Start()
    {
        currentTime = startingTime;
        timerActivated = false;
    }
    void Update()
    {
        Animation();
        Countdown();
        TimeChecker();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            timerActivated = true;
        }
        
    }

    private void Animation()
    {
        if(timerActivated == true)
        {
            elapsed += Time.deltaTime;
            if (elapsed >= 1f)
            {
                elapsed = elapsed % 1f;
                anim.SetTrigger("ticked");
            }
            if (currentTime <= 10)
            {
                anim.SetBool("red", true);
            }
        }
    }

    private void Countdown()
    {
        if(timerActivated == true)
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");

            if (currentTime <= 0)
            {
                currentTime = 0;
                // Tiden är slut och kod för slut meny ska in här <----
            }
        }
    }

    public void StartTimer()
    {
        timerActivated = true;
    }

    private void TimeChecker()
    {
        if(currentTime <= 0)
        {
            SceneManager.LoadScene(endScreenScene);
        }
    }


}
