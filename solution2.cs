using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
//Check if itemID 3 exist in the list and print out true or false
//Grab all the items with buffer greater than 20 and then print them out
//Calculate the average of all the buff stats
[System.Serializable]
public class Item
{
    public string name;
    public int id;
    public int buff;
}

public class Main : MonoBehaviour
{
    public List<Item> items;

    void Start()
    {
        var result = items.Average(items => items.buff);

        Debug.Log("Average: " + result);




    }


}
