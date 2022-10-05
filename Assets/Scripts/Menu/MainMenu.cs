using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject _canvasMainMenu;
    public GameObject _canvasParametre;
    public bool visibleMainMenu = true;
    public bool visibleParametre = false;
    [SerializeField] private AudioSource audioSource;

    void Start()
    {
        visibleMainMenu = true;
        visibleParametre = false;
        audioSource.volume = PlayerPrefs.GetFloat("SliderVolumeLevel", audioSource.volume);
    }

    public void parametre()
    {
        visibleMainMenu = !visibleMainMenu;
        visibleParametre = !visibleParametre;
        _canvasParametre.SetActive(true);
        _canvasMainMenu.SetActive(false);
    }

    public void Voitures()
    {
          SceneManager.LoadScene("Garage");
    }

    public void Quitter()
    {
        Application.Quit();
    }

}
