using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    [SerializeField]private int populationStart = 5;

    public Population population;
    public Atmosphere atmosphere;
 
    // Start is called before the first frame update
    void Start()
    {
        atmosphere = new Atmosphere();
        population = new Population(populationStart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
