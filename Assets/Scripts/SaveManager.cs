using System.Collections;
using UnityEngine;

using System.Xml;                   //Generic xml
using System.Xml.Serialization;     //xmlserializer
using System.IO;                    //Filemanagement
using System.Collections.Generic;   //For lists



public class SaveManager : MonoBehaviour {

    public static SaveManager ins;

    private void Awake()
    {
        ins = this;         //Instance of SaveManager
    }

    //List of employees
    public EmployeeDB employeeDB;

    public void Save()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(EmployeeDB));
        FileStream stream = new FileStream(Application.dataPath + "/Saves/save.xml", FileMode.Create);
        serializer.Serialize(stream, employeeDB);
        stream.Close();
    }

    public void Load()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(EmployeeDB));
        FileStream stream = new FileStream(Application.dataPath + "/Saves/save.xml", FileMode.Open);
        employeeDB = serializer.Deserialize(stream) as EmployeeDB;
        stream.Close();
    }

}

[System.Serializable]       //Be able look in the inspector
public class EmployeeEntry
{
    public string empName;     //if not public the serializer cannot look at it
    public string description;
    public int level;
    public int sprintNum;
    public int salary;
    public int motivation;
    public int talkative;
    public float[] mechanical;
    public float[] debugging;
    public float[] documentation;
    public float[] test;
    public float estimate;
    public float friendliness;
    public float helpfulness;
    public Material quirk;

}


[System.Serializable]
public class EmployeeDB
{
    [XmlArray("Employees")]
    public List<EmployeeEntry> list = new List<EmployeeEntry>();
}

public enum Material
{
    Soziable,
    Friendly,
    Teamworker
}
