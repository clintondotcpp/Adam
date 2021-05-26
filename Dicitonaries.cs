using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Create a custom class Item to work with this code
public class ItemDB : MonoBehaviour
{
    public List<Item> itemList = new List<Item>();

    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();

    void Start()
    {

        Item sword = new Item();
        sword.name = "Sword";
        sword.id = 0;

        itemDictionary.Add(0, sword);
        itemList.Add(sword);

        var item = itemDictionary[0]; //To access the items in a dictionary, you assign it to a variable, then access the fields uaing below
        item.id = 0;
        item.name = "Johann";



    }

}
