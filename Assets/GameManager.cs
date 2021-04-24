using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject PauseUI;
    public GameObject InstructionsUI;
    public GameObject GreditsUI;
    public GameObject MainMenu;
    public GameObject HitUI;
    public Text text;
    public float GameTime = 0;

    private void Update()
    {
        GameTime -= Time.deltaTime;
        text.text = "Time: " + (int)Mathf.Max(GameTime % 60, 0);

        if(GameTime <= 1)
        {
            OpenHItUI();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void PauseButton()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        PauseUI.SetActive(true);
        UnityEngine.Time.timeScale = 0f;
    }

    public void QuitPauseButton()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        PauseUI.SetActive(false);
        UnityEngine.Time.timeScale = 1f;
    }

    public void OpenCredit()
    {
        GreditsUI.SetActive(true);
        MainMenu.SetActive(false);
        
    }
    public void CloseCredit()
    {
        GreditsUI.SetActive(false);
        MainMenu.SetActive(true);
        
    }
    public void OpenInstructions()
    {
        InstructionsUI.SetActive(true);
        MainMenu.SetActive(false);
        
    }
    public void CloseInstructions()
    {
        InstructionsUI.SetActive(false);
        MainMenu.SetActive(true);
        
    }

    public void OpenHItUI()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        HitUI.SetActive(true);
        UnityEngine.Time.timeScale = 0f;
    }

    public void HItUI()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        HitUI.SetActive(false);
        UnityEngine.Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMeun()
    {
        SceneManager.LoadScene("MainScene");
        UnityEngine.Time.timeScale = 1f;
    }

    public void End()
    {
        SceneManager.LoadScene("EndScene");
    }

}
