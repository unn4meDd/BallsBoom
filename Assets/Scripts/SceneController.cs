using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject gameMenu;
    public GameObject locker;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Locker()
    {
        locker.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void BackToMenu()
    {
        locker.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
        gameMenu.SetActive(false);
    }
    public void Continue()
    {
        gameMenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Settings()
    {

    }
    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Play()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
    public void Shop()
    {

    }
    public void Pause()
    {
        gameMenu.SetActive(true);
        Time.timeScale = 0;
    }
}
