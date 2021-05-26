using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Main : MonoBehaviour
{

    public string[] names = { "Jon", "jon", "jon", "julie", "julie", "mark", "mark" };

    void Start()
    {
        var uniqueName = names.Distinct();

        foreach (var name in uniqueName)
        {
            Debug.Log("Name: " + name);

        }
    }



}
