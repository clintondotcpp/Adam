using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Main : MonoBehaviour
{

    public string[] names = { "Jon", "alex", "julie", "jessie", "david", "mark", "mat" };

    void Start()
    {
        var nameFound = names.Any(name => name == "Jon"); //When working with Linq you use the universal data type var, this is like an inline foreach loop
        //this basically read does any of the name equal Jon

        Debug.Log(nameFound);
    }



}
