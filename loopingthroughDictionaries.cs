using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Add a custom class Item, to work with this class
public class ItemDB : MonoBehaviour
{
    //Dictionaries are great for if you are working with large Lists. In an RPG game in a shop system with item ids. if you use a dictionary for your
    //inventory then you have a value mapped to those items for what items you give to them. In that way you don't have to iterate through  the dictionary 
    //Dictionaries really work well with Large lists.

    //In DIctionaries, Keys have to be unique, the values can be the same, but keys must be unique. In addition to that, the key must exist, example down below
    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();

    void Start()
    {

        Item sword = new Item();
        sword.name = "Sword";
        sword.id = 0;

        Item bread = new Item();
        bread.name = "Bread";
        bread.id = 1;

        Item cape = new Item();
        cape.name = "Cape";
        cape.id = 2;

        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, bread);
        itemDictionary.Add(2, cape);

        /*foreach(KeyValuePair<int, Item> item in itemDictionary)// To print out keys and item
        {
            Debug.Log("Key" + item.Key);
            Debug.Log("Value" + item.Value.name);
                
        }*/

        /*foreach(int key in itemDictionary.Keys) //To print out only keys
        {
            Debug.Log("Key " + key);
        }*/

        foreach (Item item in itemDictionary.Values) //To display only values
        {
            Debug.Log("Value" + item.name);
        }


        var randomItem = itemDictionary[60]; // doing this is wrong, because the index or key doesn't exist.

        //before accessing an item in a Dictionary, you have to check if that item exist
        if (itemDictionary.ContainsKey(60))
        {
            Debug.Log("We have the Item");
            var someItem = itemDictionary[60];
        }
        else
            Debug.Log("We don't ");


    }

}
