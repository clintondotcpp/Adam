using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Create a program where you assign a cube in the inspector and when you hit the space key, you pass 
    // that object into a function called ChangeColor. THe function should take both the GameObject and a color to change to
    // and the the operation should be handled within the function

    public GameObject cube;





    public void ChangeColor(GameObject obj, Color colorToAssign)
    {
        // The cube is stored in the referenced obj
        obj.GetComponent<Renderer>().material.color = colorToAssign;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor(cube, Color.blue);
        }

    }





}
