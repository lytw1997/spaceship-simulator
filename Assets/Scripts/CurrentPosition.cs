using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentPosition : MonoBehaviour
{
    private Text x;
    private  Text y;
    private  Text z;
    public Transform spaceship;
    void Start()
    {
        x = this.gameObject.transform.GetChild(0).GetComponent<Text>();
        y = this.gameObject.transform.GetChild(1).GetComponent<Text>();
        z = this.gameObject.transform.GetChild(2).GetComponent<Text>();
        x.text = "X : " + spaceship.position.x.ToString("0");
        y.text = "Y : " + spaceship.position.y.ToString("0");
        z.text = "Z : " + spaceship.position.z.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        x.text = "X : " + spaceship.position.x.ToString("0");
        y.text = "Y : " + spaceship.position.y.ToString("0");
        z.text = "Z : " + spaceship.position.z.ToString("0");
    }
}
