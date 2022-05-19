using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PopulationState
{
    public enum STATE { AWESOME, GREAT, GOOD,NEUTRAL, BAD, WORSE, SUICIDAL };
    public enum SMARTNES { WISE, VERYINTELIENT, INTELIGENT, DUMB };
    public enum LIVING { HOUSE, STREET, SHELTER };

    public SMARTNES _SMARTNES = SMARTNES.INTELIGENT;
    public STATE _STATE = STATE.NEUTRAL;
    public LIVING _LIVING = LIVING.STREET;
}
