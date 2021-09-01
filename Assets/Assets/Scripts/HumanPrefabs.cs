using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanPrefabs : MonoBehaviour
{
    [SerializeField]
    private HumanData Info;
    private SetHumanInfo setHumanInfo;
    private void Start()
    {
        setHumanInfo = GameObject.FindGameObjectWithTag("HumanInfo").GetComponent<SetHumanInfo>();
    }
    private void OnMouseDown()
    {
      
        setHumanInfo.OpenHumanPanel();
        setHumanInfo.Name.text = Info.Name;
        setHumanInfo.Age.text = Info.Age;
        setHumanInfo.Image.GetComponent<RawImage>().texture = Info.Image;
        setHumanInfo.PhoneNum.text = Info.PhoneNum;
        setHumanInfo.Location.text = Info.Location;
    }
}
