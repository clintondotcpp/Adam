using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Create a delegate of that takes 2 int and returns the sum
/// </summary>
public class Main : MonoBehaviour
{
    //we use a Func if it going to return something and type Action if it's void

    public Func<int, int, int> onGetSum;

    void Start()
    {
        onGetSum = (a, b) =>
        {
            return a + b;
        };

        onGetSum(6, 7); //we then call the anonymous method and then pass values
    }
}
