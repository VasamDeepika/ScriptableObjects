using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetHumanInfo : MonoBehaviour
{
    public GameObject HumanInfoPanel;
    public GameObject Image;
    public Text Name;
    public Text Age;
    public Text PhoneNum;
    public Text Location;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenHumanPanel()
    {
       HumanInfoPanel.SetActive(true);
    }

    public void CloseHumanPanel()
    {
        HumanInfoPanel.SetActive(false);
    }
}
