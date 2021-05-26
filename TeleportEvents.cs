using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <CHALLENGE>
/// 
/// </summary>
//Create a Program using Delegates and events where you hit the space key and assign a cube a position of (5, 2, 0).
//The cube script should subscribe tp the event and invoked when you hit the space key


//this is attached to the main camera
public class Main : MonoBehaviour
{
    public delegate void ChangeCubePosition();
    public static event ChangeCubePosition cubePosition;

    void myPosition()
    {
        if (cubePosition != null)
            cubePosition();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Create three cubes and attach this script to it
public class Cube : MonoBehaviour
{

    void CubePosition()
    {
        GetComponent<Transform>().position = new Vector3(5, 2, 0);
    }

    void Start()
    {
        Main.cubePosition += CubePosition;

    }

    void OnDisable()
    {
        Main.cubePosition -= CubePosition;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CubePosition();
        }
    }
}
