using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    #region Singelton

    public static Inventory instance;

    void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory foud !");
            return;
        }

        instance = this;
    }

    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 20;
    int i = 0;

    public List<Item> items = new List<Item>();

    public bool Add (Item item)
    {
        if (!item.isDefaultItem)
        {
            if(items.Count >= space)
            {
                Debug.Log("Not enought space");
                return false;
            }

            items.Add(item);

            if(onItemChangedCallback != null)
            {
                onItemChangedCallback.Invoke();
            }
                
        }

        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }

    public bool HaveItems(Item[] isItems)
    {
        int isAllItems = 0;

        for (int i = 0; i < isItems.Length; i++)
        {
            if (items.Contains(isItems[i]))
            {
                isAllItems++;
            }
        }

        if(isAllItems == isItems.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SwitchItem(Item item)
    {

        Item hand = items[i];
        int index = items.IndexOf(item);

        items[i] = items[index];
        items[index] = hand;

        if (i > 0) { i = 0; } else i++;

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }
}
