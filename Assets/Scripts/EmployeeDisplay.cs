using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EmployeeDisplay : MonoBehaviour {

    public Employee employeePrefab;

	// Use this for initialization
	void Start () {
        Display();
	}
	
	
	public void Display () {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

		foreach (EmployeeEntry employee in SaveManager.ins.employeeDB.list)
        {
            Employee newEmployee = Instantiate(employeePrefab) as Employee;
            newEmployee.transform.SetParent(transform, false);
            newEmployee.Display(employee);
        }
	}
}
