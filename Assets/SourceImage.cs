using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SourceImage : MonoBehaviour
{
    [SerializeField] Sprite borat;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Borat.BoratEnable == true)
        {
            this.gameObject.GetComponent<Image>().sprite = borat;
        }
    }
}
