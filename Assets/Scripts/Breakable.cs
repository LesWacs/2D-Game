using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : Collidable
{
    public Prop prop;

    protected override void OnCollide(Collider2D coll)
    {
        if ((coll.name == "Player") && Input.GetButtonDown("Fire1"))
        {
            if (Inventory.instance.items.Count != 0)
            {
                for (int i = 0; i < 2; i++){

                    if (Inventory.instance.items[i].GetType() == typeof(Tool))
                    {
                        Inventory.instance.items[i].Use();
                        OnBreak();
                        break;
                    }
                }
            }         
        }
    }

    protected virtual void OnBreak()
    {
        Instantiate(prop.drop, this.transform);
        Destroy(this.gameObject);
    }
}
