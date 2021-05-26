using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //How to pause a system or game
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0; // This is to complete pause the system
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1; // 0r 0.5, This puts the system in slow motion
        }

    }

}
