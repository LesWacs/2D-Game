using UnityEngine.UI;
using UnityEngine;

public class CraftingUI : MonoBehaviour
{
    public GameObject craftingUI;
    public Button button;

    void Update()
    {
        if (Input.GetButtonDown("Crafting"))
        {
            craftingUI.SetActive(!craftingUI.activeSelf);
        }
    }
}
