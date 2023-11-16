using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    
    public int distance = 0;
    public int hiScore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI yourScoreText;
    public TextMeshProUGUI highScoreText;
    public GameObject gameOverScreen;
    public string gameMode;
    public TransitionScript transition;

    void Start()
    {
        transition = GameObject.FindGameObjectWithTag("Transition").GetComponent<TransitionScript>();
        gameMode = PlayerPrefs.GetString("gameMode");
        Debug.Log("highscore loading");
        hiScore = PlayerPrefs.GetInt("highscore");
        Debug.Log("highscore loaded" + hiScore);

        highScoreText.enabled = false;
        yourScoreText.enabled = false;

        if (gameMode == "StoryMode")
        {
            scoreText.enabled = false;
        }
        else if(gameMode == "EndlessMode")
        {
            scoreText.enabled = true;

        }
    }

    public void increaseDistance(int distanceToAdd)
    {
        distance = distance + distanceToAdd;
        scoreText.text = distance.ToString();
    }

    public void restartGame()
    {
        transition.nextScene(1);
    }

    public void gameOver()
    {      
        if(distance > hiScore)
        {
            PlayerPrefs.SetInt("highscore", distance);
        }


        if(gameMode == "EndlessMode")
        {
            highScoreText.enabled = true;
            yourScoreText.enabled = true;
        }

        gameOverScreen.SetActive(true);

        highScoreText.text = "Hi Score: " + PlayerPrefs.GetInt("highscore");
        yourScoreText.text = "Your Score: " + distance;


    }
}
