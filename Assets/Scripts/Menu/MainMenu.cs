using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private GameObject _canvasMainMenu;
    [SerializeField] private GameObject _canvasParametre;
    private bool visibleMainMenu = true;
    private bool visibleParametre = false;

    void Start()
    {
        visibleMainMenu = true;
        visibleParametre = false;
    }

    public void parametre()
    {
        visibleMainMenu = !visibleMainMenu;
        visibleParametre = !visibleParametre;
        _canvasMainMenu.SetActive(false);
        _canvasParametre.SetActive(true);
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
