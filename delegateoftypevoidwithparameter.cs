using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Use a delegate of type void that returns the sum of two numbers. Use a lambda to avoid use of a dedicated method
/// </summary>
public class Main : MonoBehaviour
{
    //if we are using a void type delegate we use an Action, if we are using return type delegate we use func

    public Action<int, int> Sum;


    void Start()
    {
        Sum = (a, b) =>
        {
            int total = a + b;
            if (total < 100)
            {
                Debug.Log("Total is small");
            }
            Debug.Log("Total " + total);
        };

        Sum(5, 2);
    }
}
