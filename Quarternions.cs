using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MyScript : MonoBehaviour
{
    [SerializeField]
    private GameObject cubePrefab;


    // Use this for initialization
    void Start()
    {

    }






    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cubePrefab, Vector3.zero, Quaternion.Euler(0, 35, 0));
        }
    }





}
