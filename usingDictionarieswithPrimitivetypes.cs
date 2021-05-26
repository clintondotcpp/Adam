using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Dictionary<string, int> people = new Dictionary<string, int>();

    public Dictionary<int, string> books = new Dictionary<int, string>();
    //It is important to know that dictionary items can only be looked up with their key; which is the first argument

    void Start()
    {
        people.Add("Clinton", 23);
        people.Add("Kofoworola", 20);
        people.Add("Kanyinsola", 19);
        people.Add("Davina", 25);

        int kanyinsolasAge = people["Kanyinsola"];
        Debug.Log("Kanyinsola's age " + kanyinsolasAge);
        Debug.Log("Her age again" + people["Kanyinsola"]);

        books.Add(0, "Thinking like a programmer");
        books.Add(1, "How to win every argument");

        Debug.Log(books[1]);

        foreach (KeyValuePair<int, string> book in books)
        {
            Debug.Log("Book: " + book.Value);
        }





    }
}
