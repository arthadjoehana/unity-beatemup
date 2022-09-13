using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] string _levelToLoad;

    public GameObject settingwindow;
    public void startGame()
    {
        SceneManager.LoadScene(_levelToLoad);
    }

    public void SettingButton()
    {
        settingwindow.SetActive(true);
    }
    public void closedTabSetting()
    {
        settingwindow.SetActive(false);

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}





   
