using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TO CHECK IF AN ITEM EXISTS
[System.Serializable]
public class item
{
    public int itemID;
    public string name;
    public string description;
}
public class Player : MonoBehaviour
{
    // create a program in which an item is randomly selected from an array



    public item[] myItems;

    void Start()
    {
        foreach (var item in myItems)
        {
            if (item.itemID == 7)
            {
                Debug.Log("You have this item");
            }
            else
            {
                Debug.Log("You do not have this item!");
            }

        }






    }
    // Update is called once per frame
    void Update()
    {

    }





}
