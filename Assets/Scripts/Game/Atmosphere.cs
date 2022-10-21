using UnityEngine.UI;
using UnityEngine;
using System;

[System.Serializable]
public class Atmosphere
{
    public PieChart pieChart = new PieChart();

    public int Nitrogen = (int)(int.MaxValue * 0.78f);   
    public int Oxygen = (int)(int.MaxValue * 0.21f);
    public int Argon = (int)(int.MaxValue * 0.0097f);
    public int CarbonDioxide = (int)(int.MaxValue * 0.0003f);
    public float totalParticles()
    {
        return (Nitrogen + Oxygen + Argon + CarbonDioxide);
    }


    private float[] GetDataSetOfAtmosphere()
    {
        float tp = totalParticles();

        return new float[] {
            (float)Nitrogen / tp,
            (float)Oxygen / tp,
            (float)Argon / tp,
            (float)CarbonDioxide / tp
        };


    }



    public void LoadPieChart()
    {
        pieChart.SetImageValues(GetDataSetOfAtmosphere());
    }
    public Atmosphere()
    {
        LoadPieChart();
    }
}


[System.Serializable]
public class PieChart
{
    [SerializeField]private Image[] images = new Image[4];
    
    public PieChart()
    {
        GetImages();
    }

    private void GetImages()
    {
        GameObject[] _imgaes = GameObject.FindGameObjectsWithTag("pieChart");
        for (int i = 0; i < _imgaes.Length; i++)
        {
            images[i] = _imgaes[_imgaes.Length-1-i].GetComponent<Image>();
        }
    }

    public void SetImageValues(float[] dataSet)
    {
        float value = 0;
        for (int i = 0; i < images.Length; i++)
        {
            value += dataSet[i];
            images[i].fillAmount = value;
        }
    }
}