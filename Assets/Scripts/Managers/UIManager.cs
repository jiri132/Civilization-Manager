using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIManager : MonoBehaviour
{
    /*public EventSystem e;
    public GameObject LastOBJ;
    private void Start()
    {
        e = this.gameObject.GetComponent<EventSystem>();
    }

    private void Update()
    {
        SelectedThisItem();
    }

    public void  SelectedThisItem()
    {
        Debug.Log($"Selected this object: {e.currentSelectedGameObject}");
        
        if (e.currentSelectedGameObject != LastOBJ)
        {
            LastOBJ.GetComponentInChildren<Text>().text = LastOBJ.GetComponentInChildren<Text>().text.Trim('>');
            LastOBJ.GetComponentInChildren<Text>().text = LastOBJ.GetComponentInChildren<Text>().text.Trim(' ');
            Text t = e.currentSelectedGameObject.GetComponentInChildren<Text>();
            string n = t.text;
            t.text = "> " + n;
        }
       

        LastOBJ = e.currentSelectedGameObject;

    }*/


    #region STATIC ChangeText functions
    public static void ChangeText(Text text, string value)
    {
        text.text = value;
    }
    public static void ChangeText(Text text, float value)
    {
        text.text = value.ToString();
    }
    #endregion
}

