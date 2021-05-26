using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int apples;




    // Use this for initialization
    void Start()
    {
        StartCoroutine(AddApplesRoutine());

    }

    // Update is called once per frame
    void Update()
    {


    }
    IEnumerator AddApplesRoutine()
    {
        for (int i = 0; i < 100; i++)
        {
            apples++;
            yield return new WaitForSeconds(1.0f);


        }
    }
}
