using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    
    public GameObject gameOverScreen;
    public static bool isLevelCompleted;
    public GameObject levelCompletedScreen;

    public GameObject PauseMenuScreen;
    public static Vector2 lastCheckPointPos = new Vector2(-3, 0);
    public static int numberOfCoins;

    public TextMeshProUGUI coinText;
    

    private void Awake()
    {
        numberOfCoins = PlayerPrefs.GetInt("NumberOfCoins", 0);
        isGameOver = false;
        GameObject.FindGameObjectWithTag("Player").transform.position = lastCheckPointPos;
        isLevelCompleted = false;

    }


    // Update is called once per frame
    void Update()
    {
        coinText.text = numberOfCoins.ToString();
        if(isGameOver)
        {
            gameOverScreen.SetActive(true);
        }
        else if(isLevelCompleted)
            {
            levelCompletedScreen.SetActive(true);
        }
    }
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseMenuScreen.SetActive(true);  }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PauseMenuScreen.SetActive(false);
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

    

