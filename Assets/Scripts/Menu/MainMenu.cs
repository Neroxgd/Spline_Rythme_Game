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
    [SerializeField] private List<GameObject> vehicule = new List<GameObject>();
    private int _indexV = 0;

    void Start()
    {
        visibleMainMenu = true;
        visibleParametre = false;
        audioSource.volume = PlayerPrefs.GetFloat("SliderVolumeLevel", audioSource.volume);
        _indexV = PlayerPrefs.GetInt("Voiture_index", 0);
        SetVoiture();
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

    public void SetVoiture()
    {
        for (int i = 0; i < vehicule.Count; i++)
        {
            if (i == _indexV)
                vehicule[i].SetActive(true);
            else
                vehicule[i].SetActive(false);
        }
    }
}
