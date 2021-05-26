using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //ULTIMATE PRINT OUT CHALLENGE
    //Create a program that prints out 1-10 and then prints only even numbers to 20 and only odd numbers to 30


    // Use this for initialization
    void Start()
    {
        for (int i = 0; i <= 30; i++)
        {
            if (i <= 10)
            {
                Debug.Log(i);

            }
            if (i > 9 && i < 21)
            {
                if (i % 2 == 0)
                {
                    Debug.Log(i);
                }
            }
            if (i > 21 && i < 30)
            {
                if (i % 2 == 1)
                {
                    Debug.Log(i);

                }
            }


        }


    }
    // Update is called once per frame
    void Update()
    {


    }
}
