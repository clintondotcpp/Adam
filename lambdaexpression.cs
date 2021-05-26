using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    //public delegate int CharacterLength(string text);

    public Func<string, int> CharacterLength; //takes in a type string and returns an int

    void Start()
    {

        CharacterLength = (name) => name.Length; 
        //this is a lambda expression which is basically  a goto. 
        //This takes in a parameter goto and returns name.length
        int count = CharacterLength("John");
        Debug.Log(count);
    }

    /*public int GetCharacter(string name)
    {
        return name.Length;
    }*/
}
