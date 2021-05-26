using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    //This is an internal method that handles the Collider, the object player is stored in the variable other
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // code
            //This can then add points or game power ups 
            Destroy(this.gameObject);
        }
    }

    
}
