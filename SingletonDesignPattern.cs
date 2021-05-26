using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager _instance; // this means there will only be one instance of this across all classes.
    public static GameManager Instance    // to allow other classes communicate with it, we make public static, they can get it but not set it
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Game Manager is NULL");

            return _instance; //if it's not null return instance
        }
    }
    //Manager classes should be communicated "with", not the other way around, the game manager can talk to all scripts except the player script. The player should
    // communicate with the gameManager

    void Awake()
    {
        _instance = this; //We initialize the singleton _instance in void Awake and assign it to "this" script the object is attached to.
        //An instance is null if it's not assigned in awake
    }

    public void DisplayName()
    {
        Debug.Log("My name is Jonathan");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    void Start()
    {
        GameManager.Instance.DisplayName();
    }

    //Manager classes should be communicated "with", not the other way around, the game manager can talk to all scripts except the player script. The player should
    // communicate with the gameManager
}
