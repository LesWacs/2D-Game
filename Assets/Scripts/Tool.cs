using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Tool", menuName = "Inventory/Tool")]
public class Tool : Item
{
    public int durability = 2;

    public override void Use()
    {
        durability--;
        if(durability == 0)
        {
            Inventory.instance.items.Remove(this);
            Inventory.instance.onItemChangedCallback();
            Debug.Log("Tool destroyed");
        }
    }
}
