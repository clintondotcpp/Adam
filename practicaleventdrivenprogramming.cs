using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//setting up the inspector is shown in the practicaleventprogramming picture on Desktop
public class Player : MonoBehaviour
{

    public delegate void OnDeath();
    public static event OnDeath onDeath;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Death();
        }
    }


    void Death()
    {
        if (onDeath != null)
            onDeath(); //always use the event not the delegate when assigning to methods
    }
}

//2nd script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void OnEnable()
    {
        Player.onDeath += ResetPlayer; //We are assigning the onDeath method to the resetplayer method
    }

    void ResetPlayer() //this is similar to onDeath() so it is assigned to it
    {
        Debug.Log("Resetting Player");
    }
}

//3rd script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public int deathCount;
    public Text deathCountText;

    void OnEnable()
    {
        Player.onDeath += UpdateDeathCount;
    }

    public void UpdateDeathCount()
    {
        deathCount++;
        deathCountText.text = "Death Count: " + deathCount;
    }
}
