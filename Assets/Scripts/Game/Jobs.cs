using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum JOB { Farmer, Engineer, Scientist, Builder  /* To be detemined */ }
public enum EMPLOYMENT { Unemployed, Employed, Child }; //Added Child

[System.Serializable]
public class Jobs
{
    public void Work(Person p)
    { 
        if (p.Employment == EMPLOYMENT.Unemployed) { return; }
        switch (p.Job)
        {
            default:
                break;
        }

        //If age of person is below 18, they are added to the child class, of which is not Employed or Unemployed.
        if(p.age > 18) { p.Employment = EMPLOYMENT.Child; }
    }
}
