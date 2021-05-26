using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Maanger classes can talk to each other, BUT they should never have to talk to any class that's not a singleton. The player talks to the manager classes and
    //the manager classes should never have to talk to player

    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("GameManager is null");

            return _instance;
        }





    }

    void Awake()
    {
        _instance = this;
    }

    public void DisplayMessage()
    {
        Debug.Log("My Name is Clinton.");
    }

}

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
                Debug.LogError("GameManager is null");

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

    void Start()
    {
        GameManager.Instance.DisplayMessage();
        UIManager.Instance.UpdateScore(60);
    }
}
