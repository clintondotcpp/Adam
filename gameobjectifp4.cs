using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject cube;
    public int points;

    // Use this for initialization
    void Start()
    {
        cube.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            points += 25;
            if (points > 50)
            {
                cube.GetComponent<Renderer>().material.color = Color.green;
            }
        }

    }
}
