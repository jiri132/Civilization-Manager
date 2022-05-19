using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationManager : MonoBehaviour
{
    public List<Person> PeopleAlive = new List<Person>();
    public List<Person> PeopleDead = new List<Person>();
    public int housingSpaces = 20;

    public void PopulationCalculation()
    {
        foreach (Person person in PeopleAlive.ToArray())
        {
            person.GiveFood(GameManager.instance.inventoryManager.food);
            person.GrowingUp();
            if (person.work.JOB != Jobs.JOBS.NOTHING) { person.DoJob(); }
        }
    }
}
