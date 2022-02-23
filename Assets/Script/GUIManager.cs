using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GUIManager : MonoBehaviour
{
    public bool GameIsPaused;
    public GameObject pauseMenGUI;
    // Update is called once per frame
    private void Start()
    {
        
    }
    void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        GameObject.Find("Ciel").GetComponent<CielControl>().enabled = true;
        pauseMenGUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        GameObject.Find("Ciel").GetComponent<CielControl>().enabled = false;
        pauseMenGUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
