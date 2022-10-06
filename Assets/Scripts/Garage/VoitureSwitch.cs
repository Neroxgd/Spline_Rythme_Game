using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoitureSwitch : MonoBehaviour
{
    [SerializeField] private List<GameObject> vehicule = new List<GameObject>();
    private int _index = 0;

    public void SwitchCar()
    {
        vehicule[_index].SetActive(false);
        _index++;
        if (_index >= vehicule.Count)
            _index = 0;
        vehicule[_index].SetActive(true);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
