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
    public AudioSource audioSourceButton;
    [SerializeField] private List<GameObject> vehicule = new List<GameObject>();
    private int _indexV = 0;
    private static bool firstStart = true;

    void Start()
    {
        visibleMainMenu = true;
        visibleParametre = false;
        audioSource.volume = PlayerPrefs.GetFloat("SliderVolumeLevel", audioSource.volume);
        if (firstStart == false)
        {
            SetVoiture();
        }
            
        firstStart = false;
    }

    public void parametre()
    {
        visibleMainMenu = !visibleMainMenu;
        visibleParametre = !visibleParametre;
        _canvasParametre.SetActive(true);
        _canvasMainMenu.SetActive(false);
        audioSourceButton.Play();
    }

    public void Voitures()
    {
        audioSource.Play();
        SceneManager.LoadScene("Garage");
    }

    public void Jouer()
    {
        audioSource.Play();
        SceneManager.LoadScene(1);
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void SetVoiture()
    {
        for (int i = 0; i < vehicule.Count; i++)
        {
            if (i == PlayerPrefs.GetInt("Voiture_index"))
                vehicule[i].SetActive(true);
            else
                vehicule[i].SetActive(false);
        }
    }
}
