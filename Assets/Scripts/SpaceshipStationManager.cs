using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceshipStationManager : MonoBehaviour
{
    public GameObject spaceshipStationPrefabs;

    public Transform playerTransform;
    private float spawnZ = 0.0f;
    private float spawnX = 0.0f;
    private float spawnY = -28.4f;
    private float groundLength;
    private float groundHeight;
    private float groundLeftRight;
    public static GameObject nextStation;
    private GameObject gO;
    private bool isNextStationExists = false;

    private List<GameObject> activeStation;
    
    public Transform directionalArrow;

    void Start()
    {
        //playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        activeStation = new List<GameObject>();
        //SpawnStation for game start
        for(int i=0; i<2; i++){
            spawnStation();
        }
        isNextStationExists = true;
    }

    void Update()
    {
        float distance = Vector3.Distance (playerTransform.position, nextStation.transform.position);
        //Debug.Log(distance);
        // if(distance > 100 && !isNextStationExists){
        //     spawnStation();
        //     isNextStationExists = true;
        //     deleteStation();
        // }
        if(isNextStationExists && distance < 50){
             spawnStation();
             //isNextStationExists = false;
             deleteStation();
        }
        if(isNextStationExists){
            directionalArrow.LookAt(nextStation.transform);
        }
    }


    void spawnStation()
    {
        int changeSign;
        gO = Instantiate(spaceshipStationPrefabs) as GameObject;
        gO.transform.SetParent(transform);
        gO.transform.position = new Vector3(spawnX, spawnY, spawnZ);
        nextStation = gO;
        //Vector3.forward * spawnZnew 
        changeSign = randomPandN();
        if(changeSign == 0){
            groundLength = -RandomZ();
        }else{
            groundLength = RandomZ();
        }
        changeSign = randomPandN();
        if(changeSign == 0){
            groundLeftRight = -RandomX();
        }else{
            groundLeftRight = RandomX();
        }
        changeSign = randomPandN();
        if(changeSign == 0){
            groundHeight = -RandomY();
        }else{
            groundHeight = RandomY();
        }
        
        spawnZ += groundLength;
        spawnY += groundHeight;
        spawnX += groundLeftRight;
        activeStation.Add(gO);
    }

    void deleteStation(){
        Destroy(activeStation[0]);
        activeStation.RemoveAt(0);
    }

    private float RandomZ()  
    {  
        float randomIndex = Random.Range(600, 2000);  
        //Debug.Log(randomIndex);
        return randomIndex;  
    }

    private float RandomX()
    {
        float randomIndex = Random.Range(600, 2000);
        return randomIndex;
    }

    private float RandomY()
    {
        float randomIndex = Random.Range(300, 600);
        return randomIndex;
    }

    private int randomPandN()
    {
        int randomIndex = Random.Range(0, 2);
        return randomIndex;
    }
}
