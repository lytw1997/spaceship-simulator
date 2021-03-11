using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public GameObject pauseMenu;

    void Start()
    {
        if(PlayerPrefs.HasKey("QualityLevel")){
            QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("QualityLevel"));
        }
        if(PlayerPrefs.HasKey("PlayerVolume")){
            audioMixer.SetFloat("volume", PlayerPrefs.GetFloat("PlayerVolume"));
        }
        FindObjectOfType<AudioManager>().PlaySound("GameSound");
    }

    public void Resume()
    {
        ClosePauseMenu();
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        OpenPauseMenu();
        Time.timeScale = 0f;
    }

    public void loadMenuScene(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
    }

    public void quitGame(){
        Application.Quit();
    }

    void OpenPauseMenu(){
        pauseMenu.SetActive(true);
    }

    void ClosePauseMenu(){
        pauseMenu.SetActive(false);
    }
}
