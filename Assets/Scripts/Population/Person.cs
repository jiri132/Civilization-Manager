using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Person
{
    public Work work;
    public PopulationState populationState;
    public string name;
    public int age = 0;
    public int workingHours = 0;
    public float health = 100;
}
