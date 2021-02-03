using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;  //public so we can assign the player to this variable in the inspector
    Vector3 offset;  //empty Vector3 to store the starting position of the camera

    // Start is called before the first frame update
    void Start()
    {
        //store camera's starting postiion so we casn keep the same offset as the ball moves
        offset = transform.position - player.transform.position;
    }

    //Late Update is called after all Update() methods are processed
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;  //updates the camera's position as the ball moves
    }
}
