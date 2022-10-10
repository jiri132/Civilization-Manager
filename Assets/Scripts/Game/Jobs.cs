using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum JOB { Farmer, Engineer, Scientist, Builder  /* To be detemined */ }
public enum EMPLOYMENT { Unemployed, Employed };

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
    }
}
