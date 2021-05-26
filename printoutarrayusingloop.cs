using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // create a program in which an item is randomly selected from an array

    public string[] itemName;
    public int[] itemID;



    void Start()
    {





    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < itemID.Length; i++)
            {
                if (itemName[i] == "knife")                      //if(itemID[i] == "7")
                                                                 //{
                {                                       //OR       
                                                        //Debug.Log(itemName[i]
                    Debug.Log("itemID: " + itemID[i]);          //}

                }
            }



        }
    }





}
