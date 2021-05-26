using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    private static UIManager _instance;
    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                //this works if there's no UIManager gameobject(so delete the gameobject, this creates a gameobject by itself. Refer to the Player script for gameobject instantiation
                GameObject go = new GameObject("UI Manager");
                go.AddComponent<UIManager>();
            }


            return _instance;
        }





    }

    void Awake()
    {
        _instance = this;
    }

    public void UpdateScore(int score)
    {
        Debug.Log("Score " + score);
        Debug.Log("Notifying game manager");
        GameManager.Instance.DisplayMessage(); //Maanger classes can talk to each other, they should never have to talk to anyone that's not a singleton
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //benefits of working with singletons, lazy instantion and global instantiation.
    void Start()
    {
        GameManager.Instance.DisplayMessage();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UIManager.Instance.UpdateScore(40); // this works with the lazy instatiation

        }
    }
}
