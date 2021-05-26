using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable<T>
{
    //an interface is a contract
    //Interfaces are similar to abstract classes in the sense that they can force implementations and while an abstract class can be thought of as
    //a partial template, interfaces can be thought of as a contract and whatever's in the contract must be implemented.
    //Interfaces don't allow for any implementation and cannot contain fields. You are only allowed to use methods and properties.
    //Interfaces allow for Polymorphism in OOP. Where and object shares relevance.

    //There are no public or private field, everything is assumed public

    int Health { get; set; }

    void Damage(int damageHealth);

}

//2nd script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IDamagable<int>, IShoot //// interfaces allows multiple inheritance, in this case, it forces a universal health system on each player,
                                                             //you can have several interfaces, it simulates a plug in play environment
{
    public int Health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void Damage(int damageHealth)
    {
        Health -= damageHealth;
    }

    public void Shoot()
    {
        throw new System.NotImplementedException();
    }

}
//3rd script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable<string>, IShoot  //// interfaces allows multiple inheritance, in this case, it forces a universal health system on each player,
                                                                //you can have several interfaces, it simulates a plug in play environment
{
    public int Health
    {

        get => throw new System.NotImplementedException();

        set => throw new System.NotImplementedException();
    }

    public void Damage(string damageHealth)
    {
        Health -= damageHealth;
    }

    public void Shoot()
    {
        throw new System.NotImplementedException();
    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

//4th script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShoot
{
    void Shoot();
}
