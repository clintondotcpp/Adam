using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is attached to the main camera
public class Main : MonoBehaviour
{
    //We used events instead of delegates because events have inherent security and delegates do not. If we used delegates other classes or scripts will
    //be able to invoke your methods. events allow only classes to subscribe and unsubscribe from our delegates.
    //Always unsubscribe after subscribing to avoid creating error in your application
    public delegate void ActionClick();
    public static event ActionClick onClick;

    public delegate void FallClick();
    public static event FallClick Fall;

    public void ButtonClick()
    {
        //in events listeners subscribe to events, working with events allows gameobjects to be self contained amd not depend on the main script or each other
        if (onClick != null) //just like an event we make sure an it's not all, that is to make sure someone is listening
            onClick();
        //turn all cubes red.
    }

    public void FallButton()
    {
        if (Fall != null)
            Fall();
    }
}

//2nd script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Create three cubes and attach this script to it
public class Cube : MonoBehaviour
{

    void Start()
    {
        Main.onClick += TurnRed;
    }

    void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    void OnDisable()
    {
        Main.onClick -= TurnRed;
    }
}

//3rd
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Main.Fall += Fall;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Fall()
    {

        GetComponent<Rigidbody>().useGravity = true;
    }

    void OnDisable()
    {
        Main.Fall -= Fall;
    }
}

