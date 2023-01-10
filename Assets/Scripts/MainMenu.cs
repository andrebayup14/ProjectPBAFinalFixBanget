using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject panelLevel;
    public GameObject panelHow;

    public void StartGameTrack1()
    {
        SceneManager.LoadScene("Track 1");
    }
    public void StartGameTrack2()
    {
        SceneManager.LoadScene("track2");
    }
    public void OpenLevelSetup()
    {
        panelLevel.SetActive(true);
    }

    public void CloseLevelSetup()
    {
        panelLevel.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }
    public void OpenHelpSetup()
    {
        panelHow.SetActive(true);
    }

    public void CloseHelpSetup()
    {
        panelHow.SetActive(false);
    }
}

