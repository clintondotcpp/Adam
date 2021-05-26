using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    //A delegate maybe described as a variable that holds several methods
    public delegate void ChangeColor(Color newColor);
    public ChangeColor onColorChange; //this allows us to assign this variable
    //to a any method that matches, the above delegate signature

    public delegate void OnComplete(); 
    //this is going to get called  
    //when you complete a method
    //any variable of type delegate can be assigned to any method 
    //given that their signatures match
    public OnComplete onComplete; 
    //this variable for 
    //instance can be assigned 
    //to Void Start() cos they have
    //similar signature

    void Start()
    {
        //Basically what we are doing is storing those 
        //methods in variables and invoking them
        onColorChange = UpdateColor;
        onColorChange(Color.green); //This is invoke these 
        //and automatically call this methods in void start;

        //to assign multicast we do a plus equal to
        onComplete += Task;
        onComplete += Task2;
        onComplete += Task3;

        onComplete -= Task;
        onComplete -= Task2;
        onComplete -= Task3;


        // best practice says before invoking a delegate
        //method, you have to  check if it's null as shown below
        //if it's null and the method is called, 
        //it's going to return an  error
        if (onComplete != null)
            onComplete();
    }

    void UpdateColor(Color newColor)
    {
        Debug.Log("Changing color to " + newColor.ToString());
    }

    void Task()
    {
        Debug.Log("Task 1 completed");
    }

    //delegates also gives us the benefits of working
    //with multitask, 
    //it allows us to have a handful of 
    //methods applied to them
    void Task2()//multicast
    {
        Debug.Log("Task 2 completed");
    }

    void Task3() //multicast
    {
        Debug.Log("Task 3 completed");
    }
}
