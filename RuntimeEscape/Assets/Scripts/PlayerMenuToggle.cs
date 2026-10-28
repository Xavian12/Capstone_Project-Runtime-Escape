using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMenuToggle : MonoBehaviour
{
    public GameObject playerMenuCanvas;
    public GameObject objectiveCanvas;
    public GameObject inventoryCanvas;

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

    private void Start()
    {
        if (playerMenuCanvas != null)
        {
            playerMenuCanvas.SetActive(false);
        }
    }

    private void ToggleMenu(InputAction.CallbackContext context)
    {
        if (playerMenuCanvas != null)
        {
            bool isOpening = !playerMenuCanvas.activeSelf;

            playerMenuCanvas.SetActive(isOpening);

            if (!isOpening)
            {
                if (objectiveCanvas != null)
                {
                    objectiveCanvas.SetActive(false);
                }

                if (inventoryCanvas != null)
                {
                    inventoryCanvas.SetActive(false);
                }
            }
        }
    }
}