using UnityEngine;
using TMPro;

public class InventoryNoteDisplay : MonoBehaviour
{
    public TextMeshProUGUI noteDescription;

    [TextArea(3, 5)]
    public string noteMessage = "Your next clue will appear here.";

    public void ShowNote()
    {
    if (noteDescription != null)
        {
        if (noteDescription.text == noteMessage)
            {
            noteDescription.text = "";
            }
        else
            {
            noteDescription.text = noteMessage;
            }
        }
    }

    private void OnDisable()
    {
        if (noteDescription != null)
        {
            noteDescription.text = "";
        }
    }
}