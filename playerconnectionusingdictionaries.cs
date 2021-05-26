using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string name;
    public int id;

    public Player(int id)
    {
        this.id = id;
    }

}

public class Main : MonoBehaviour
{

    public Dictionary<int, Player> playerDictionary = new Dictionary<int, Player>();

    void Start()
    {
        Player p1 = new Player(0);
        p1.id = 0;
        p1.name = "Jimmy";


        Player p2 = new Player(1);
        p2.id = 1;
        p2.name = "Kim";

        Player p3 = new Player(2);
        p3.id = 2;
        p3.name = "Jenny";

        playerDictionary.Add(p1.id, p1); //alternatively playerDictionary.Add(0, p1)
        playerDictionary.Add(p2.id, p2);
        playerDictionary.Add(p3.id, p3);



    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var player = playerDictionary[2]; //alternatively playerDictionary[p3, if player p3 is a global variable]
            Debug.Log("Name" + player.name);
        }
    }


}
