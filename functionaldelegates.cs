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

        CharacterLength = GetCharacter;
        int count = CharacterLength("John");
    }

    public int GetCharacter(string name)
    {
        return name.Length;
    }
}
