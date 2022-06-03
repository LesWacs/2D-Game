using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Prop", menuName = "Inventory/Prop")]
public class Prop : ScriptableObject
{
    new public string name = "New Prop";
    public Sprite icon = null;

    public GameObject drop;

}
