using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : Collidable
{
    public Item item;

    protected override void OnCollide(Collider2D coll)
    {
        if ((coll.name == "Player") && Input.GetButtonDown("Take"))
        {
            OnCollect();
        }

    }

    protected virtual void OnCollect()
    {
        Debug.Log("Picking up" + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);

        if (wasPickedUp)
        {
            Destroy(this.gameObject);
        }
        
    }
}
