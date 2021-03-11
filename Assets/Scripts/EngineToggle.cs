using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class EngineToggle : MonoBehaviour
{
    private bool onEngine = false;

    void Update()
    {
        if(onEngine){
            SpaceshipMovement.isEngineStart = true;
        }else{
            SpaceshipMovement.isEngineStart = false;
        }
    }

    public void setEngineEnable(float engine){
        if(engine == 1){
            onEngine = true;
        }else{
            onEngine = false;
        }
    }
}
