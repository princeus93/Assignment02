using System;
using UnityEngine;
using UnityEngine.UI;  //Required to use "Text" object and other UI elements

public class PlayerController : MonoBehaviour
{
    public float speed = 800.0f; //public so we can change this value in the inspector
    public Text scoreText;  //"scoreText" will store our UI Text object
    private int count = 0;  //"count" will keep track of how many cubes we picked up
    public Text winText;

    public float size;

    // Update is called once per frame
    void FixedUpdate()  //Infinite loop while we are in play mode
    {
        float moveHorizontal = Input.GetAxis("Horizontal");  //Left-right input stored as a float between -1.0 and 1.0
        float moveVertical = Input.GetAxis("Vertical");  //Down-up input stored as a float between -1.0 and 1.0

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);  //Direction of the sum of both input values

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);  //Applies force in desired direction

       
    }

    private void Update()
    {
        GetComponent<Rigidbody>().transform.localScale = new Vector3(size, size, size);
    }

    public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public void AdjustSize(float newSize)
    {
        size = newSize;
        //GetComponent<Rigidbody>().transform.localScale = new Vector3(size, size, size);
    }



    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count += 1;  //Adds 1 to count each time we pick up a cube

            scoreText.text = "Score: " + count; //Updates the text property of scoreText
            if(count >= 16)
            {
                winText.gameObject.SetActive(true);
            }
        }
        
    }
}
