using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Craft", menuName = "Inventory/Craft")]
public class Craft : ScriptableObject
{
    public Item[] itemsNeeded;
    public new Item itemCrafted;
  
}
