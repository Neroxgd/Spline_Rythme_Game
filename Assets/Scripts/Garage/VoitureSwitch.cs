using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoitureSwitch : MonoBehaviour
{
    [SerializeField] private List<GameObject> vehicule = new List<GameObject>();
    private static int _index = 0;

    public void SwitchCar()
    {
        vehicule[_index].SetActive(false);
        _index++;
        if (_index >= vehicule.Count)
            _index = 0;
        vehicule[_index].SetActive(true);
        PlayerPrefs.SetInt("Voiture_index", _index);
    }

    void Start()
    {
        for (int i = 0; i < vehicule.Count; i++)
        {
            if (i == _index)
                vehicule[i].SetActive(true);
            else
                vehicule[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
