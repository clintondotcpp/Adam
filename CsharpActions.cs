using System; //this namespace must be included to work with Actions
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //public delegate void onDeathReceived(int currentHealth);
    //public static event onDeathReceived onDamage;

    public static Action<int> onDamageReceived; //This works equal as a delegate, it's an Action of type void that takes in an int parameter. The only difference betweem action and delegates is in the declaration

    public int Health { get; set; }

    void Start()
    {
        Health = 10;
    }

    public void Damage()
    {
        Health--;
        if (onDamageReceived != null)
            onDamageReceived(Health);

    }
}

//2nd script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    void OnEnable()
    {
        Player.onDamageReceived += UpdateHealth;
    }


    public void UpdateHealth(int health)
    {
        Debug.Log("Current health: " + health);
    }
}

