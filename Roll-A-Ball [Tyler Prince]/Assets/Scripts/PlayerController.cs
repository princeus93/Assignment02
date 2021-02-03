using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 800.0f; //public so we can change this value in the inspector

    // Update is called once per frame
    void FixedUpdate()  //Infinite loop while we are in play mode
    {
        float moveHorizontal = Input.GetAxis("Horizontal");  //Left-right input stored as a float between -1.0 and 1.0
        float moveVertical = Input.GetAxis("Vertical");  //Down-up input stored as a float between -1.0 and 1.0

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);  //Direction of the sum of both input values

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);  //Applies force in desired direction
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
        }
    }
}
