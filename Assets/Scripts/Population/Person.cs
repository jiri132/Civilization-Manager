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
    public int workingDays = 0;
    public float health = 100;

    public void MasteryCalucaltion()
    {
        switch (workingDays)
        {
            case 0:
                work.MASTERY = Jobs.MASTERY.NOOBY;
                break;
            case 13:
                work.MASTERY = Jobs.MASTERY.APRENTICE;
                break;
            case 20:
                work.MASTERY = Jobs.MASTERY.MASTER;
                break;
            case 40:
                work.MASTERY = Jobs.MASTERY.GRANDMASTER;
                break;


            default:
                Debug.Log("NotEnogh hours to gain a new mastery");
                break;
        }
    }

    public void DoJob()
    {
        inventoryManager im = GameManager.instance.inventoryManager;
        int x;
        switch (work.JOB)
        {
            /*case Jobs.JOBS.HOUSEBUILDER:
                //Make this manual
                //x = AprenticeCheck(4);
                //GameManager.instance.populationManager.housingSpaces += x;
                //GameManager.instance.planetManager.Planet.AddCO2(x);
                break;*/
            case Jobs.JOBS.FARMER:
                x = AprenticeCheck(6);
                im.food += x;
                GameManager.instance.planetManager.Planet.RemoveCO2(x);
                break;
            case Jobs.JOBS.LUMBERER:
                x = AprenticeCheck(1);
                im.wood += x;
                GameManager.instance.planetManager.Planet.AddCO2(x);
                break;
            case Jobs.JOBS.MINER:
                x = AprenticeCheck(1);
                im.wood += x;
                GameManager.instance.planetManager.Planet.AddCO2(x);
                break;
        }
        workingDays++;
    }

    private int AprenticeCheck(int multiplier)
    {
        switch (work.MASTERY)
        {
            case Jobs.MASTERY.GRANDMASTER:
                return 5 * multiplier;
            case Jobs.MASTERY.MASTER:
                return 4 * multiplier;
            case Jobs.MASTERY.EXPERT:
                return 3 * multiplier;
            case Jobs.MASTERY.APRENTICE:
                return 2 * multiplier;
            case Jobs.MASTERY.NOOBY:
                return 1 * multiplier;
        }
        return 0;
    }

    public void GiveFood(int FoodStorage)
    {
        switch (populationState._GROWN)
        {
            case PopulationState.GROWN.BABY:
                FoodStorage -= 1;
                break;
            case PopulationState.GROWN.KID:
                FoodStorage -= 2;
                break;
            case PopulationState.GROWN.TEENAGER:
                FoodStorage -= 5;
                break;
            case PopulationState.GROWN.ADULT:
                FoodStorage -= 8;
                break;
            case PopulationState.GROWN.ELDER:
                FoodStorage -= 5;
                break;
            default:
                break;
        }
        if (FoodStorage < 0)
        {
            FoodStorage = 0;
            GameManager.instance.populationManager.PeopleAlive.Remove(this);
            GameManager.instance.populationManager.PeopleDead.Add(this);
        }
    }

    public void GrowingUp()
    {
        age++;
        switch (age)
        {
            case 0: populationState._GROWN = PopulationState.GROWN.BABY;
                break;
            case 6: populationState._GROWN = PopulationState.GROWN.KID;
                break;
            case 12: populationState._GROWN = PopulationState.GROWN.TEENAGER;
                break;
            case 18: populationState._GROWN = PopulationState.GROWN.ADULT;
                break;
            case 65: populationState._GROWN = PopulationState.GROWN.ELDER;
                break;
            default:
                Debug.Log("Couldn't get a new grown update");
                break;
        }
    }
}
