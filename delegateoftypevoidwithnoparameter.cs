using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Create a delegate of type void that takes in no parameters and outputs the gameobject name
/// </summary>
public class Main : MonoBehaviour
{

    public Action OnGetName;

    void Start()
    {
        OnGetName = () => Debug.Log("Name" + gameObject.name); //this takes in no parameters and outputs the gameobject the script is on
        OnGetName(); //always call the  methods when using delegates
    }
}
