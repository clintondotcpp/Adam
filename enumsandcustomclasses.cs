using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to Main Camera
[System.Serializable]
public class Item
{
    public string name;
    public int id;
    public Sprite icon;

    public enum ItemType
    {
        None,
        Consumable,
        Weapon
    }

    public ItemType itemType;

    public void Action()
    {
        switch (itemType)
        {
            case ItemType.Consumable:
                Debug.Log("This is a consumable");
                break;
            case ItemType.Weapon:
                Debug.Log("This is a weapon");
                break;
        }
    }

}

//2nd script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{

    public List<Item> items = new List<Item>();

    void Start()
    {
        items[0].Action();
    }

}
