using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Note: You have to attach this script to the cube
    [SerializeField]
    private int _speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //This method moves the cube 
        float _horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(_horizontalInput, 0, 0) * _speed * Time.deltaTime);
    }
}
