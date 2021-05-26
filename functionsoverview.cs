using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    public void Damage(int damageHealth)
    {
        health -= damageHealth;
        if (health < 1)
        {
            health = 0;
            Destroy(this.gameObject);
        }

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Damage(5);
        }
    }





}
