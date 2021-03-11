using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceshipColorManagement : MonoBehaviour
{
    public GameObject [] spaceShipPart;
    public Material [] materials;
    private string color;

    void Start()
    {

        if(PlayerPrefs.HasKey("Color")){
             color = PlayerPrefs.GetString("Color");
        }else{
            color = "gray";
        }

        for(int i=0; i<spaceShipPart.Length; i++){
            if(color == "red" && (i==0 || i == 4)){
                spaceShipPart[i].GetComponent<MeshRenderer> ().material = materials[1];
            }else if(color == "red" && (i!=0 || i!=4)){
                spaceShipPart[i].GetComponent<MeshRenderer> ().material = materials[0];
            }else if(color == "blue" && (i==0 || i == 4)){
                spaceShipPart[i].GetComponent<MeshRenderer> ().material = materials[5];
            }else if(color == "blue" && (i!=0 || i!=4)){
                spaceShipPart[i].GetComponent<MeshRenderer> ().material = materials[4];
            }else if(color == "green" && (i==0 || i == 4)){
                spaceShipPart[i].GetComponent<MeshRenderer> ().material = materials[3];
            }else if(color == "green" && (i!=0 || i!=4)){
                spaceShipPart[i].GetComponent<MeshRenderer> ().material = materials[2];
            }else if(color == "gray" && (i==0 || i == 4)){
                spaceShipPart[i].GetComponent<MeshRenderer> ().material = materials[7];
            }else if(color == "gray" && (i!=0 || i!=4)){
                spaceShipPart[i].GetComponent<MeshRenderer> ().material = materials[6];
            }
        }
    }
}
