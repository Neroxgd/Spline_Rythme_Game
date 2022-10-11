using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoitureSwitch : MonoBehaviour
{
    [SerializeField] private List<GameObject> vehicule = new List<GameObject>();
    [SerializeField] private List<GameObject> vehiculemini = new List<GameObject>();
    private static int _index = 0;
    [SerializeField] private AudioSource audioSource;

    public void SwitchCar()
    {
        vehicule[_index].SetActive(false);
        vehiculemini[_index].SetActive(false);
        _index++;
        if (_index >= vehicule.Count)
            _index = 0;
        vehicule[_index].SetActive(true);
        vehiculemini[_index].SetActive(true);
        PlayerPrefs.SetInt("Voiture_index", _index);
        audioSource.Play();
    }

    void Start()
    {
        for (int i = 0; i < vehicule.Count; i++)
        {
            if (i == _index)
            {
                vehicule[i].SetActive(true);
                vehiculemini[i].SetActive(true);
            }
                
            else
            {
                vehicule[i].SetActive(false);
                vehiculemini[i].SetActive(false);
            }
                
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
