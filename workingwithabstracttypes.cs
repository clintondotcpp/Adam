using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Employee : MonoBehaviour
{

    public static string companName = "Clinton Global Group"; //Making this variable static is going to make shared amongst all instances of the object
    public string employeeName;

    public abstract void CalculateMonthlySalary();

}

//2nd script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartTime : Employee
{
    public int hoursWorked;
    public int hourlyRates;

    public override void CalculateMonthlySalary()
    {
        throw new System.NotImplementedException();
    }
}

//3rd script
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullTime : Employee
{

    public int salary;

    public override void CalculateMonthlySalary()
    {
        throw new System.NotImplementedException();
    }
}

