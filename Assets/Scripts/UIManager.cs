using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
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

