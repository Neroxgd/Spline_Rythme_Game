using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Parametre : MonoBehaviour
{
    [SerializeField] private Dropdown _resolution;
    [SerializeField] private AudioSource _audiosource;
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI txtVolume;
    [SerializeField] private MainMenu _mainmenu;

    public void Set_Resolution()
    {
        switch (_resolution.value)
        {
            case 0:
                Screen.SetResolution(1920, 1080, true);
                break;
            case 1:
                Screen.SetResolution(640, 360, true);
                break;
        }
    }

    public void VolumeChange()
    {
        _audiosource.volume = _slider.value;
        PlayerPrefs.SetFloat("SliderVolumeLevel", _audiosource.volume);
        txtVolume.text = "Volume " + (_audiosource.volume*100).ToString("00") + "%";
    }

    public void RetourToMenu()
    {
        _mainmenu.visibleMainMenu = !_mainmenu.visibleMainMenu;
        _mainmenu.visibleParametre = !_mainmenu.visibleParametre;
        _mainmenu._canvasMainMenu.SetActive(true);
        _mainmenu._canvasParametre.SetActive(false);
    } 

    void Start()
    {
        _slider.value = _audiosource.volume;
        txtVolume.text = "Volume " + (_audiosource.volume*100).ToString("00") + "%";
    }
}
