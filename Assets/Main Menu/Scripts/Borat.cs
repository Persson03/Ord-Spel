using UnityEngine;
using UnityEngine.EventSystems;

public class Borat : MonoBehaviour
{

    public static bool BoratEnable = false;

    [SerializeField] GameObject borat;
    // Start is called before the first frame update
    public void Start()
    {
        if (BoratEnable == false)
        {
            borat.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void EnableBorat()
    {

        if (BoratEnable == false)
        {
            BoratEnable = true;
        }

        else if (BoratEnable == true)
        {
            BoratEnable = false;
        }

        if (BoratEnable == true)
        {
            borat.SetActive(true);
            this.gameObject.SetActive(false);
        }
        else
        {
            borat.SetActive(false);
        }


        EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(null);
    }
}
