using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectiveMenuToggle : MonoBehaviour
{
    public GameObject objectiveCanvas;
    public InputActionReference toggleAction;

    private void OnEnable()
    {
        if (toggleAction != null)
        {
            toggleAction.action.performed += ToggleMenu;
            toggleAction.action.Enable();
        }
    }

    private void OnDisable()
    {
        if (toggleAction != null)
        {
            toggleAction.action.performed -= ToggleMenu;
        }
    }

    private void ToggleMenu(InputAction.CallbackContext context)
    {
        if (objectiveCanvas != null)
        {
            objectiveCanvas.SetActive(!objectiveCanvas.activeSelf);
        }
    }
    public GameObject inventoryCanvas;

    public void ToggleObjectives()
    {
        if (objectiveCanvas != null)
        {
            bool isOpening = !objectiveCanvas.activeSelf;

        if (inventoryCanvas != null)
        {
            inventoryCanvas.SetActive(false);
        }

        objectiveCanvas.SetActive(isOpening);
        }
    }
}