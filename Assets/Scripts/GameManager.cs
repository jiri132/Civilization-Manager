using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region #defininig all the managers
    public PopulationManager populationManager;
    public inventoryManager inventoryManager;
    public PlanetManager planetManager;
    //UI manager is class with onyly static functions
    #endregion
    #region #SingleTon
    //#defining a singleton
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }
    #endregion
    #region #gameLoop

    #endregion
}
