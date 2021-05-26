using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    //Create a list or array of 3 gameobjects to spawn and randomly spawn them with a random position on the screen between -10 and 10
    // on the X/Y when you hit the space key. Every object you spawn should be stored in a list called ObjectsCreated. When you have spawned 10 objects
    //you will no longer be able to spawn objects and will turn all objects created green and clear the list.

    // Start off by creating Prefabs of different types


    public GameObject[] SpawnList = new GameObject[3];
    public List<GameObject> objectsCreated = new List<GameObject>();
    public int SpawnCount { get; set; }

    private bool _initColorChange;


    void Start()
    {


    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (SpawnCount == 10)
            {
                _initColorChange = true;
                return;

            }

            var objectsToSpawn = SpawnList[Random.Range(0, SpawnList.Length)];
            var x = Random.Range(-10, 10);
            var y = Random.Range(-10, 10);
            GameObject go = Instantiate(objectsToSpawn, new Vector3(x, y, 0), Quaternion.identity) as GameObject;

            objectsCreated.Add(go); // this is the gameobject we are adding

            SpawnCount++;
        }

        if (_initColorChange == true) //this prevent this from being called 60 frames per second
        {
            _initColorChange = false;
            foreach (var p in objectsCreated)
            {
                p.GetComponent<MeshRenderer>().material.color = Color.green;
            }
            objectsCreated.Clear();
        }
    }
}
