using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region #defininig all the managers
    public PlanetManager planetManager;
    #endregion
    #region #defining all Variables



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
       
    }
    #endregion
    #region #gameLoop


    
    

    #endregion
}
