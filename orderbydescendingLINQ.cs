using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//Create a program where you have an integer array of quiz grades, the quiz grades should be between 0-100. Filter through the grades and create a new collection
//of only passing grades, above 69
public class Main : MonoBehaviour
{

    public int[] grades = { 50, 59, 78, 94, 100, 73, 60, 98, 88, 40, 34, 90, 81, 61, 23, 59, 69, 70, 80, 57 };

    void Start()
    {
        var gradingSystem = grades.Where(n => n > 69).OrderByDescending(g => g).Reverse(); //orders the array and reverses it
        foreach (var grade in gradingSystem)
        {
            Debug.Log("Grade: " + grade);
        }
    }


}
