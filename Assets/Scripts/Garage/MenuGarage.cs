using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGarage : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    public void GarageToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    void Start()
    {
        audioSource.volume = PlayerPrefs.GetFloat("SliderVolumeLevel", audioSource.volume);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
