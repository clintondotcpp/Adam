//FIRST SCRIPT

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemDB : MonoBehaviour
{
    //Create an empty object which you would call ItemDB, and attach thid script to it
    public List<Item> ItemDatabase = new List<Item>();

    public void AddItem(int itemID, Player player) //this takes in two parameters, the second one is to access the class Player, or an object of the class
    {
        foreach (var item in ItemDatabase)
        {
            if (item.id == itemID)
            {
                Debug.Log("We have the item");
                player.Inventory[0] = item; // this populates our item inventory
                return;
            }
        }
        Debug.Log("We don't have the item");
    }

    public void RemoveItem(int itemID, Player player)
    {
        foreach (var item in ItemDatabase)
        {
            if (item.id == itemID)
            {
                player.Inventory[0] = null; //this removes the array
            }
        }
    }
}

// 2nd SCRIPT
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string name;
    public int id;
    public Sprite icon;
}

//3rd script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //create a cube called Player
    public Item[] Inventory = new Item[10];

    private ItemDB _itemDataBase;

    void Start()
    {
        _itemDataBase = GameObject.Find("ItemDB").GetComponent<ItemDB>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _itemDataBase.AddItem(0, this); //this means, that player
        }

        else if (Input.GetKeyDown(KeyCode.R))
        {
            _itemDataBase.RemoveItem(0, this);
        }
    }

}
