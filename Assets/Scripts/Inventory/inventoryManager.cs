using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventoryManager : MonoBehaviour
{
    public int food;
    public int wood;
    public int stone;

    public Text tfood, twood, tstone;

    public void InventoryUpdate()
    {
        UIManager.ChangeText(tfood, food);
        UIManager.ChangeText(twood, wood);
        UIManager.ChangeText(tstone, stone);
    }
}
