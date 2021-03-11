using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Dropdown qualityDropdown;
    public Slider gameVolume;

    void Start()
    {
        int currentQuality;
        qualityDropdown.ClearOptions();
        List<string> qualityOptions = new List<string> ();
        if(PlayerPrefs.HasKey("QualityLevel")){
            currentQuality = PlayerPrefs.GetInt("QualityLevel");
            setQuality(currentQuality);
        }
        else{
            currentQuality = QualitySettings.GetQualityLevel();
        }
        //Debug.Log(QualitySettings.names);
        for(int i=0; i<QualitySettings.names.Length; i++){
            qualityOptions.Add(QualitySettings.names[i]);
            //Debug.Log(QualitySettings.names[i]);
        }
        qualityDropdown.AddOptions(qualityOptions);
        qualityDropdown.value = currentQuality;
        qualityDropdown.RefreshShownValue();
        if(PlayerPrefs.HasKey("PlayerVolume")){
            gameVolume.value = PlayerPrefs.GetFloat("PlayerVolume");
        }
    }
    public void setVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        PlayerPrefs.SetFloat("PlayerVolume", volume);
    }

    public void setQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        PlayerPrefs.SetInt("QualityLevel", qualityIndex);
    }
}
