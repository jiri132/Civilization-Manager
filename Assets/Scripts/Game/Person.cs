using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Person
{
    public enum Gender { Female, Male }

    public Person(Gender gender)
    {
        this.gender = gender;
    }

    public Person(Gender gender, int age)
    {
        this.gender = gender;
        this.age = age;
    }

    public EMPLOYMENT Employment = EMPLOYMENT.Unemployed;
    public JOB Job;

    public string name = "";
    public int age = 0;
    public Gender gender;

    public void Breath()
    {

    }


}
