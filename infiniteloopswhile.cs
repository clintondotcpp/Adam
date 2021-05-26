using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{





    // Use this for initialization
    void Start()
    {
        StartCoroutine(LoopRoutine());

    }

    // Update is called once per frame
    void Update()
    {


    }
    IEnumerator LoopRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            Debug.Log("Spawning Enemies every second!");
        }
    }
}
