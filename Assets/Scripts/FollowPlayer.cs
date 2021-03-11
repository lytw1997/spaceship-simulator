using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    //private Vector3 offset = new Vector3(0, 100, 150);
    private Vector3 moveVector;
    //private float transition = 0.0f;
    //private float animationDuration = 3.0f;
    //private Vector3 animationOffset = new Vector3(0, 5, 5);

    void Start()
    {
        //offset = transform.position - player.position;
    }

    void FixedUpdate()
    {
        //moveVector = player.position + offset;
        //moveVector.x = 0;
        //moveVector.y = Mathf.Clamp(moveVector.y, 3, 5);
        //if(transition > 1.0f)
        //{
            //transform.position = moveVector;
            transform.position = player.position;
        //}else{
        //    transform.position = Vector3.Lerp(moveVector + animationOffset, moveVector, transition);
        //    transition += Time.deltaTime * 2/ animationDuration;
        //    transform.LookAt(player.position + Vector3.up);
        //}
        
    }
}
