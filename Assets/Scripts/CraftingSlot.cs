using UnityEngine.UI;
using UnityEngine;

public class CraftingSlot : MonoBehaviour
{
    public Image icon;
    public Button button;
    public Craft craft;
    private bool isCrafted;

    public void Craft()
    {
        isCrafted = Crafting.instance.Craft(craft);
        if (isCrafted)
        {
            Debug.Log("Item Crafted !");
        }
        else
        {
            Debug.Log("Missing item");
        }
    }
}
