using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public GameObject _canvasMainMenu;
    public GameObject _canvasParametre;
    public bool visibleMainMenu = true;
    public bool visibleParametre = false;

    void Start()
    {
        visibleMainMenu = true;
        visibleParametre = false;
    }

    public void parametre()
    {
        visibleMainMenu = !visibleMainMenu;
        visibleParametre = !visibleParametre;
        _canvasParametre.SetActive(true);
        _canvasMainMenu.SetActive(false);
    }

    public void Quitter()
    {
        Application.Quit();
    }
}
