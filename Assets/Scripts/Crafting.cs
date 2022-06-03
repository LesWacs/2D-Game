using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafting : MonoBehaviour
{
    #region Singelton

    public static Crafting instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Crafting foud !");
            return;
        }

        instance = this;
    }

    #endregion

    Inventory inventory;

    void Start()
    {
        inventory = Inventory.instance;
    }

   public bool Craft(Craft craft)
    {
        if (inventory.HaveItems(craft.itemsNeeded))
        {
            for (int i = 0; i < craft.itemsNeeded.Length; i++)
            {
                inventory.Remove(craft.itemsNeeded[i]);
            }

            inventory.Add(new Tool craft.itemCrafted);

            return true;
        }
        else
        {
            return false;
        }

        
    }
}
