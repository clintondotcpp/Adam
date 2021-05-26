using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // How fast are you going

    // Create a program where you increment the value of speed by 5 every second and when
    // speed is greater  than Maxspeed stop incrementing 
    // Maxspeed should be random between 60 and 120

    public float mySpeed;
    public float maxSpeed;

    void Start()
    {
        maxSpeed = Random.Range(60f, 120f);
        StartCoroutine(SpeedCounter());

    }
    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpeedCounter()
    {
        /*while (true)
        {
            mySpeed += 5;
            if (mySpeed > maxSpeed)
                break;
            yield return new WaitForSeconds(1.0f);
                
        }*/
        // OR
        do
        {
            yield return new WaitForSeconds(1.0f);
            mySpeed += 5;

        }
        while (mySpeed < maxSpeed);

    }



}
