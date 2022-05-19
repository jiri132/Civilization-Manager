using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Planet
{
    public float Temperature = 0;
    [Range(50,1000)]
    public int MaxPeoplePopulaiton;
    public float CO2;
    
}
