using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    public bool GameStatusIsPaused;
    public bool GameMenuIsPaused;
    public GameObject pauseStatusGUI;
    public GameObject pauseMenuGUI;
    // Update is called once per frame
    private void Start()
    {
        
    }
    void Update()
    {
        if (Keyboard.current.tabKey.wasPressedThisFrame)
        {
            if (GameStatusIsPaused)
            {
                ResumeStatus();
            }
            else
            {
                PauseStatus();
            }
        }
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (GameMenuIsPaused)
            {
                ResumeMenu();
            }
            else
            {
                PauseMenu();
            }
        }
    }

    public void ResumeStatus()
    {
        GameObject.Find("Ciel").GetComponent<CielControl>().enabled = true;
        pauseStatusGUI.SetActive(false);
        Time.timeScale = 1f;
        GameStatusIsPaused = false;
    }

    public void ResumeMenu()
    {
        GameObject.Find("Ciel").GetComponent<CielControl>().enabled = true;
        pauseMenuGUI.SetActive(false);
        Time.timeScale = 1f;
        GameMenuIsPaused = false;
    }

    public void PauseStatus()
    {
        GameObject.Find("Ciel").GetComponent<CielControl>().enabled = false;
        pauseStatusGUI.SetActive(true);
        Time.timeScale = 0f;
        GameStatusIsPaused = true;
    }

    public void PauseMenu()
    {
        GameObject.Find("Ciel").GetComponent<CielControl>().enabled = false;
        pauseMenuGUI.SetActive(true);
        Time.timeScale = 0f;
        GameMenuIsPaused = true;
    }

    public void ExitMenu()
    {
        GameObject.Find("Ciel").GetComponent<CielControl>().enabled = true;
        SceneManager.LoadScene("MenuScene");
    }
}
