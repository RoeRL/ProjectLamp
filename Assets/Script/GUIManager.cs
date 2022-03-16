using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    [HideInInspector] public bool GameStatusIsPaused;
    [HideInInspector] public bool GameMenuIsPaused;
    [HideInInspector] public bool BagIsOpen;
    [Header("Property: ")]
    public Animator anim;
    public Image blackFadeImage;
    [Header("GUI: ")]
    public GameObject pauseStatusGUI;
    public GameObject pauseMenuGUI;
    public GameObject bagGUI;
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
        if (Keyboard.current.iKey.wasPressedThisFrame)
        {
            if (BagIsOpen)
            {
                CloseBag();
            }
            else
            {
                OpenBag();
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

    public void OpenBag()
    {
        GameObject.Find("Ciel").GetComponent<CielControl>().enabled = false;
        Time.timeScale = 0f;
        BagIsOpen = true;
        bagGUI.SetActive(true);
    }

    public void CloseBag()
    {
        GameObject.Find("Ciel").GetComponent<CielControl>().enabled = true;
        bagGUI.SetActive(false);
        Time.timeScale = 1f;
        BagIsOpen = false;
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        StartCoroutine(Fading());
    }
    private IEnumerator Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => blackFadeImage.color.a == 1);
        SceneManager.LoadScene("GUITest");
    }
}
