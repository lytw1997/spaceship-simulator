using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StationPosition : MonoBehaviour
{
    private Text x;
    private  Text y;
    private  Text z;
    void Start()
    {
        x = this.gameObject.transform.GetChild(1).GetComponent<Text>();
        y = this.gameObject.transform.GetChild(2).GetComponent<Text>();
        z = this.gameObject.transform.GetChild(3).GetComponent<Text>();
        if(SpaceshipStationManager.nextStation != null){
            x.text = "X : " + SpaceshipStationManager.nextStation.transform.position.x.ToString("0");
            y.text = "Y : " + SpaceshipStationManager.nextStation.transform.position.y.ToString("0");
            z.text = "Z : " + SpaceshipStationManager.nextStation.transform.position.z.ToString("0");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(SpaceshipStationManager.nextStation != null){
            x.text = "X : " + SpaceshipStationManager.nextStation.transform.position.x.ToString("0");
            y.text = "Y : " + SpaceshipStationManager.nextStation.transform.position.y.ToString("0");
            z.text = "Z : " + SpaceshipStationManager.nextStation.transform.position.z.ToString("0");
        }
    }
}
