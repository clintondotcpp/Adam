using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject cube;
    private int _nextColor;





    // Use this for initialization
    void Start()
    {
        cube.GetComponent<Renderer>().material.color = Color.white;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            _nextColor = 1;


        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            _nextColor = 2;


        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            _nextColor = 3;


        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _nextColor = 4;


        }

        switch (_nextColor)
        {
            case 1:
                cube.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 2:
                cube.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 3:
                cube.GetComponent<Renderer>().material.color = Color.green;
                break;
            case 4:
                cube.GetComponent<Renderer>().material.color = Color.black;
                break;

        }





    }
}
