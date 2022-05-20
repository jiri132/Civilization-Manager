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
        }
        else
        {
            Destroy(this);
        }
    }
    #endregion

    #region #start function
    private void Start()
    {
        populationManager = GameObject.FindObjectOfType<PopulationManager>();
        inventoryManager = GameObject.FindObjectOfType<inventoryManager>();
        planetManager = GameObject.FindObjectOfType<PlanetManager>();
    }
    #endregion
    #region #gameLoop


    public void DayCalculations()
    {
        populationManager.PopulationCalculation();
        planetManager.PlanetCalculation();
        inventoryManager.InventoryUpdate();
    }

    

    #endregion
}
