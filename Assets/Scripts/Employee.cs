using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Employee : MonoBehaviour {

    public string empName;
    public string description;
    public int level;
    public int sprintNum;
    public int salary;
    public int motivation;
    public int talkative;
    public string quirk;
    public float[] mechanical;
    public float[] debugging;
    public float[] documentation;
    public float[] test;
    public float estimate;
    public float friendliness;
    public float helpfulness;
    

    public void Display (EmployeeEntry employee)
    {
        empName = employee.empName;
        Text text = gameObject.GetComponentInParent(typeof(Text)) as Text;
        text.text = employee.empName;
        description = employee.description;
        level = employee.level;
        sprintNum = employee.sprintNum;
        salary = employee.salary;
        motivation = employee.motivation;
        talkative = employee.talkative;
        mechanical = employee.mechanical;
        debugging = employee.debugging;
        documentation = employee.documentation;
        test = employee.test;
        estimate = employee.estimate;
        friendliness = employee.friendliness;
        helpfulness = employee.helpfulness;
        quirk = employee.quirk.ToString();
    }
}
