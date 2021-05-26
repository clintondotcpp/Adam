using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject[] cubes;






    void Start()
    {







    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < cubes.Length; i++)
            {

                cubes[0].GetComponent<Renderer>().material.color = Color.red;

            }


        }

    }





}
