using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // create a program in which an item is randomly selected from an array

    public string[] names;
    public int[] ages;
    public string[] cars;
    public int randomID;

    void Start()
    {





    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            randomID = Random.Range(0, names.Length);
            Debug.Log(randomID);
            Debug.Log("Name: " + names[randomID] + "age: " + ages[randomID] + "car: " + cars[randomID]);
        }
    }





}
