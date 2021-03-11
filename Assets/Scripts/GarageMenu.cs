using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GarageMenu : MonoBehaviour
{
    public Sprite [] spaceshipImage;
    public Image currentImage;

    void Start()
    {
        if(PlayerPrefs.HasKey("Color")){
            changeImage(PlayerPrefs.GetString("Color"));
        }
    }

    // Update is called once per frame
    public void changeColor(string color){
        PlayerPrefs.SetString("Color", color);
        changeImage(color);
    }

    void changeImage(string color){
        if(color == "red"){
            currentImage.sprite = spaceshipImage[1];
        }else if(color == "green"){
            currentImage.sprite = spaceshipImage[3];
        }else if(color == "blue"){
            currentImage.sprite = spaceshipImage[2];
        }else if(color == "gray"){
            currentImage.sprite = spaceshipImage[0];
        }
    }
}
