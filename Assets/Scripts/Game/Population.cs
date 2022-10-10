using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Population
{
    public int housingSpaces = 5;
    public List<Person> people = new List<Person>();


    public Population(int populationStart)
    {
        //the start of th population
        for (int i = 0; i < populationStart; i++)
        {
            int GenderNum = Random.Range(0, 1+1);
            switch (GenderNum)
            {
                case 0:
                    people.Add(new Person(Person.Gender.Female, Random.Range(20, 30)));

                    break;

                case 1:
                    people.Add(new Person(Person.Gender.Male, Random.Range(20,30)));

                    break;

                default:
                    break;
            }
        }
    }

}
