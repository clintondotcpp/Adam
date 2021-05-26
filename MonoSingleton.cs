using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//MonoSingleton is the ability to turn any manager class into a singleton and use it as a singleton and initialize values
//Each time you create a manager class you would need a singleton, to hava a singleton that works across multiple manager classes we use MonoSingleton

//In programming you have to learn how to modularize everything, every you learn how to simplify everything
//MonoSingletons allow to turn any kind of class into a singleton
public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    //Making a class abstract allows to create templete class that allows other classes to inherit

    //Generics introduced in C# 2.0. It allows you to define a class with placeholders for the type of its fields, methods, parameters, etc. Generics replace these placeholders with some specific type at compile time.

    //A generic class can be defined using angle brackets<>.For example, the following is a simple generic class with a generic member variable, generic method and property.

    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError(typeof(T).ToString() + " Is Null");

            return _instance;
        }





    }

    void Awake()
    {
        _instance = (T)this;
    }

    public virtual void Init()
    {

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoSingleton<Player>
{
    public override void Init()
    {
        base.Init();

        Debug.Log("Player Initialized");
    }

}
