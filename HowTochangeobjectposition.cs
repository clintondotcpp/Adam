using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{






    private void Start()
    {
        //transform.position = new Vector3(0, 0, 5);     (1)
        //transform.position = Vector3.zero              (3)

        //ChangePosition(new Vector3(0,0,0));            (2)
        //ChangePosition();                              (1)
        // transform.position = GetPosition(3,5,6);         // (5)
        ChangePosition(new Vector3(0, 0, 5));
    }

    private void Update()
    {


    }

    public void ChangePosition(Vector3 pos) //    (2)
    {
        transform.position = pos; //              (2)
    }

    /* public Vector3 GetPosition(float x, float y, float z) //(5)
     {
         return new Vector3(x, y, z);
     }*/

    /* public Vector3 GetPosition() //(6)
     {
         return Vector3.zero;
     }*/
    /*public Vector3 GetPosition(float x, float y, float z) //(7)
    {
        Vector3 pos = new Vector3(x, y, z);
        return pos;
    }*/




}
