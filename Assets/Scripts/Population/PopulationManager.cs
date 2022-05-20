using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationManager : MonoBehaviour
{
    public List<Person> PeopleAlive = new List<Person>();
    public List<Person> PeopleDead = new List<Person>();
    public int housingSpaces = 20;

    public List<Person> WoodWorker, StoneWorker, Farmer;
    public List<Person> workless()
    {
        List<Person> p = new List<Person>();
        foreach (Person person in PeopleAlive)
        {
            if (person.work.JOB == Jobs.JOBS.NOTHING) { p.Add(person); }
        }
        return p;
    }
    public void PopulationCalculation()
    {
        foreach (Person person in PeopleAlive.ToArray())
        {
            //keeping alive logic
            person.GiveFood(GameManager.instance.inventoryManager.food);
            person.GrowingUp();

            //job logic
            person.MasteryCalucaltion();
            if (person.work.JOB != Jobs.JOBS.NOTHING) { person.DoJob(); }
        }
    }

    //when you assign wrokers to a field 
    //it automaticly adds the grandmasters of the work
    public void AssignWorkers(Jobs.JOBS job)
    {
        List<Person> GM, M, E, A, N;
        workerCatogarised(out GM, out M,out E,out A,out N);
        switch (job)
        {
            case Jobs.JOBS.FARMER:
                workerToList(GM,M,E,A,N, Farmer,Jobs.JOBS.FARMER);

                break;
            case Jobs.JOBS.LUMBERER:
                workerToList(GM, M, E, A, N, WoodWorker, Jobs.JOBS.LUMBERER);

                break;
            case Jobs.JOBS.MINER:
                workerToList(GM, M, E, A, N, StoneWorker, Jobs.JOBS.MINER);

                break;
            default:
                break;
        }
    }

    private void workerToList(List<Person> GM,List<Person> M,List<Person> Expert,List<Person> Aprentice,List<Person> Nooby, List<Person> WorkingList, Jobs.JOBS job)
    {
        if (GM.Count > 0)
        {
            Person p = GM[0];
            p.work.JOB = job;
            WorkingList.Add(p);
            GM.Remove(p);
            return;
        }
        if (M.Count > 0)
        {
            Person p = M[0];
            p.work.JOB = job;
            WorkingList.Add(p);
            M.Remove(p);
            return;
        }
        if (Expert.Count > 0)
        {
            Person p = Expert[0];
            p.work.JOB = job;
            WorkingList.Add(p);
            Expert.Remove(p);
            return;
        }
        if (Aprentice.Count > 0)
        {
            Person p = Aprentice[0];
            p.work.JOB = job;
            WorkingList.Add(p);
            Aprentice.Remove(p);
            return;
        }
        if (Nooby.Count > 0)
        {
            Person p = Nooby[0];
            p.work.JOB = job;
            WorkingList.Add(p);
            Nooby.Remove(p);
            return;
        }
    }

    private void workerCatogarised(out List<Person> GM, out List<Person> M, out List<Person> Expert, out List<Person> Aprentice, out List<Person> Nooby)
    {
        GM = new List<Person>();
        M = new List<Person>();
        Expert = new List<Person>();
        Aprentice = new List<Person>();
        Nooby = new List<Person>();


        foreach (Person person in workless().ToArray())
        {
            switch (person.work.MASTERY)
            {
                case Jobs.MASTERY.GRANDMASTER:
                    GM.Add(person);
                    break;
                case Jobs.MASTERY.MASTER:
                    M.Add(person);
                    break;
                case Jobs.MASTERY.EXPERT:
                    Expert.Add(person);
                    break;
                case Jobs.MASTERY.APRENTICE:
                    Aprentice.Add(person); 
                    break;
                case Jobs.MASTERY.NOOBY:
                    Nooby.Add(person);
                    break;
                default:
                    break;
            }
        }
    }

    public void BuildHouse()
    {

    }
}
