using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Create a delegate of type int that returns the length of the gameobject name
/// </summary>
public class Main : MonoBehaviour
{
    //we use a Func if it going to return something and type Action if it's void

    public Func<int> onGetName;

    void Start()
    {
        onGetName = () => this.gameObject.name.Length;

        int count = onGetName();
        Debug.Log("Count " + count);

        onGetName();
    }
}
