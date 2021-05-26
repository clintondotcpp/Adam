using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //Create a program that checks if the player is dead or not . When you hit the space key you should 
    //damage the player by a certain amount. If the player is dead(health less than 1), print out the 
    // "The Player has died"

    //Bonus: Prevent the damage function from being  called once Player is dead and no negative health values.

    public int myHealth = 100;

    public void Damage(int damageRec)
    {

        myHealth -= damageRec;
        if (IsDead())        {
            myHealth = 0;

            Debug.Log("Player is dead!");

        }
    }


    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsDead() == false)
        {
            Damage(Random.Range(0, 20));

        }



    }

    public bool IsDead()
    {
        return myHealth < 1;
    }




}
