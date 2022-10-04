using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parametre : MonoBehaviour
{
    [SerializeField] private Dropdown _resolution;

    public void Set_Resolution()
    {
        switch (_resolution.value)
        {
            case 0:
                Screen.SetResolution(1920, 1080, true);
                break;
            case 1:
                Screen.SetResolution(640, 360, true);
                break;
        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
