using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoratCheck : MonoBehaviour
{
    [SerializeField] GameObject borat2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Borat.BoratEnable == true)
        {
            borat2.SetActive(true);
        }
        else
        {
            borat2.SetActive(false);
        }
    }
}
