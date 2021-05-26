using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Create a program that's going to return allof the objects into an array. Then iterate
    //through that that array
    //and apply random colors to each of the cubes.

    //An array that's dynamically populated. 
    //It stores game objects grabbing every player dynamically
    public GameObject[] players;





    private void Start()
    {
        //To populate players array, all I have to do is say
        players = GetAllPlayers();
        // It's going to gather up the players.

    }

    private void Update()
    {




    }

    //To do this, You use a custom method that's going to return all of the 
    //players.
    GameObject[] GetAllPlayers()
    {// to do the above return all of the gameobjects, we are going to create 
        //an array here of type gameobject 
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");
        foreach (var p in allPlayers)
        {
            p.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);

        }
        return allPlayers;
    }



}
