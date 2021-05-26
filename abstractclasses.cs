using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    //Abstract classes allow us to force inheritance and create easily
    //manageable and maintainable code
    //with abstract methods, we can force implementations. 
    //This allows us to create a partial template and allows the inherited 
    //implementation to finish the class
    //Abstract classes do can not be instantiated. 
    //Abstract classes hide functionality. 
    //This class must contain at least one abstract method, 
    //which is marked by the keyword or modifier abstract in the 
    //class definition
    public int speed;
    public int health;
    public int gems;

    public abstract void Attack();
    //abstract methods do not have implementations only functionality
    //A method which is declared abstract, has no “body” 
    //and declared inside the abstract class only.
    //

    //Another benefit of working with abstract classes
    //is we can have a shared combination of abstract members which fire 
    //implementation for as well as virtual methods that contain 
    //implementation that can be shared and overriden

    public virtual void Die()
    {
        Destroy(this.gameObject);
    }
}

public class MossGiant : Enemy
{
    public override void Attack() //to work with the abstract class 
        //the child class whichh contains the definition for the method
        //must have the keyword override
    {
        throw new System.NotImplementedException();
    }

    //This overrides the Die() method and also allows us to add 
    //custom particle or basically modify the method when the MossGiant Dies
    public override void Die()
    {
        base.Die();
    }
}

