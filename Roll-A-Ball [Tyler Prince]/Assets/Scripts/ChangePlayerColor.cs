using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePlayerColor : MonoBehaviour
{
    public Material matRed;
    public Material matBlue;
    public Material matPurple;
    public PlayerController player;

    public Dropdown myDropdown;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Renderer>().material = matPurple;
    }

    // Update is called once per frame
    void Update()
    {
        switch (myDropdown.value)
        {
            case 1:
                player.GetComponent<Renderer>().material = matRed;
                break;
            case 2:
                player.GetComponent<Renderer>().material = matBlue;
                break;
            case 3:
                player.GetComponent<Renderer>().material = matPurple;
                break;

        }
    }
}
