using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject gamemodeSelectorMenu;
    public GameObject storyMenu;
    public string gameMode;
    public TransitionScript transition;

    private void Start()
    {
        transition = GameObject.FindGameObjectWithTag("Transition").GetComponent<TransitionScript>();
    }

    public void gamemodeSelectorScreen()
    {
        mainMenu.SetActive(false);
        gamemodeSelectorMenu.SetActive(true);
    }
    public void storyModeChosen()
    {
        gameMode = "StoryMode";
        PlayerPrefs.SetString("gameMode", gameMode);
        gamemodeSelectorMenu.SetActive(false);
        storyMenu.SetActive(true);
    }

    public void endlessModeChosen()
    {
        gameMode = "EndlessMode";
        PlayerPrefs.SetString("gameMode", gameMode);
    }

    public void goToMenu()
    {
        transition.nextScene(0);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
