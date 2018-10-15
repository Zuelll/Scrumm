using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Employee : MonoBehaviour {

    public string theName;
    public int friendliness;
    public int helpfulness;
    public string quirk;

    public void Display (EmployeeEntry employee)
    {
        theName = employee.employeeName;
        Text text = gameObject.GetComponentInParent(typeof(Text)) as Text;
        text.text = employee.employeeName;
        friendliness = employee.employeeFriendliness;
        helpfulness = employee.employeeHelpfulness;
        quirk = employee.quirk.ToString();
    }
}
