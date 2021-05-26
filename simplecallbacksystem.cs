using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Main : MonoBehaviour
{
    //this allows us to control game logic after the coroutine is finished
    void Start()
    {
        StartCoroutine(MyRoutine(() =>    //By filling in the argument we choose what to do after the coroutine is finished, this takes in a no parameter delegate
        {
            Debug.Log("This code has finished");
            Debug.Log("Wow this is cool");
        }));
    }


    IEnumerator MyRoutine(Action onComplete = null) //To protect us as developers in making sure it's not null, by setting it to null, it's going to make
                                                    //it optional to fill in, so by setting it to null, it makes it optional as a method
    {
        yield return new WaitForSeconds(5.0f);
        if (onComplete != null)
            onComplete();

    }
}
