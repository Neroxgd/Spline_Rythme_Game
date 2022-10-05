using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoitureSwitch : MonoBehaviour
{
    [SerializeField] GameObject voiturePourrite;
    [SerializeField] GameObject Train;
    private bool active = true;

    public void SwitchCar()
    {
        voiturePourrite.SetActive(!active);
        Train.SetActive(active);
        active = !active;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
