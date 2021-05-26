using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField]
    private Transform _sphere;
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //direction = destination - position
        Vector3 directionToFace = _sphere.position - transform.position;

        Quaternion targetRotation = Quaternion.LookRotation(directionToFace);
        //We have to know the location of the mech, so we access our current location = Quaternion Look rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(directionToFace), Time.deltaTime); //Creates a rotation, with the specified upward and forward rotion
        Debug.DrawRay(transform.position, directionToFace, Color.red);
    }
}
