using UnityEngine;
using UnityEngine.EventSystems;

public class Borat : MonoBehaviour
{

    bool BoratEnable = false;

    [SerializeField] GameObject borat;
    // Start is called before the first frame update
    void Start()
    {
        borat.SetActive(false);
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
        }
        else
        {
            borat.SetActive(false);
        }

        EventSystem.current.GetComponent<EventSystem>().SetSelectedGameObject(null);
    }
}
