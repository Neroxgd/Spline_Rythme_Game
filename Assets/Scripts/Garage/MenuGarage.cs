using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGarage : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private GameObject voiture;
    [SerializeField][Range(1, 50)] private  int speedrotate = 25;
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
        voiture.transform.Rotate(Vector3.up*Time.deltaTime* speedrotate, Space.Self);
    }
}
