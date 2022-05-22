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
        UIManager.ChangeText(tfood,"Food: " + food);
        UIManager.ChangeText(twood,"Wood: " + wood);
        UIManager.ChangeText(tstone,"Stone: " + stone);
    }
}
