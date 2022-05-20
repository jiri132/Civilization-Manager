using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Planet
{
    [Range(-5f, 5f)]
    public float Temperature = 0;
    [Range(50,1000)]
    public int MaxPeoplePopulaiton;
    public float CO2;
    
    public void AddCO2(float totalCO2)
    {
        CO2 += totalCO2;
        CalculateTemperature();
    }
    public void RemoveCO2(float totalCO2)
    {
        CO2 -= totalCO2;
        CalculateTemperature();
    }

    public void CalculateTemperature()
    {

    }

}
