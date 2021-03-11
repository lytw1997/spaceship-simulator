using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MenuScript : MonoBehaviour
{
    public AudioMixer audioMixer;
    void Start()
    {
        if(PlayerPrefs.HasKey("PlayerVolume")){
            audioMixer.SetFloat("volume", PlayerPrefs.GetFloat("PlayerVolume"));
        }
        FindObjectOfType<AudioManager>().PlaySound("MenuSound");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playGame(){
        SceneManager.LoadScene("GameScene");
    }

    public void quitGame(){
        Application.Quit();
    }
}
