using UnityEngine;

public class InventoryMenuToggle : MonoBehaviour
{
    public GameObject inventoryCanvas;
    public GameObject objectiveCanvas;

    public void ToggleInventory()
    {
        if (inventoryCanvas != null)
        {
            bool isOpening = !inventoryCanvas.activeSelf;

            if (objectiveCanvas != null)
            {
                objectiveCanvas.SetActive(false);
            }

            inventoryCanvas.SetActive(isOpening);
        }
    }
}