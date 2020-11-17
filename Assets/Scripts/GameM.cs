using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameM : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject gameCompleteCanvas;
    public GameObject scoreui;
    public GameObject showPower1;
    public GameObject showPower2;
    public GameObject showPower3;
    public GameObject showPower4;
    public GameObject showPower5;
    public GameObject showPower6;
    public GameObject showPower7;
    public GameObject showPower8;
    void Start()
    {
        Time.timeScale = 1;
    }


    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void GameComplete()
    {
        scoreui.SetActive(false);
        gameCompleteCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void ShowPower1()
    {
        showPower1.SetActive(true);
        Time.timeScale = 0;
    }
    public void ShowPower2()
    {
        showPower2.SetActive(true);
        Time.timeScale = 0;
    }
    public void ShowPower3()
    {
        showPower3.SetActive(true);
        Time.timeScale = 0;
    }
    public void ShowPower4()
    {
        showPower4.SetActive(true);
        Time.timeScale = 0;
    }
    public void ShowPower5()
    {
        showPower5.SetActive(true);
        Time.timeScale = 0;
    }
    public void ShowPower6()
    {
        showPower6.SetActive(true);
        Time.timeScale = 0;
    }
    public void ShowPower7()
    {
        showPower7.SetActive(true);
        Time.timeScale = 0;
    }
    public void ShowPower8()
    {
        showPower8.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void BackToGame()
    {
            showPower1.SetActive(false);
            showPower2.SetActive(false);
            showPower3.SetActive(false);
            showPower4.SetActive(false);
            showPower5.SetActive(false);
            showPower6.SetActive(false);
            showPower7.SetActive(false);
            
        Time.timeScale = 1;
               
    }

    public void GameCompleted()
    {
        showPower8.SetActive(false);
        GameComplete();

    }
}
