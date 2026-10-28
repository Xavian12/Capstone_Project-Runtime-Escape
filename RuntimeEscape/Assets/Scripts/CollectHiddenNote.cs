using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CollectHiddenNote : MonoBehaviour
{
    public GameObject hiddenNoteButton;
    public ClassroomObjectiveManager objectiveManager;

    private bool isCollected = false;

    public void CollectNote()
    {
        if (isCollected)
        {
            return;
        }

        isCollected = true;

        // Add the note to the inventory
        if (hiddenNoteButton != null)
        {
            hiddenNoteButton.SetActive(true);
        }

        // Update training progress
        if (objectiveManager != null)
        {
            objectiveManager.CompleteChallenge();
        }

        // Remove the physical note from the classroom
                StartCoroutine(HideNote());
    }

    private System.Collections.IEnumerator HideNote()
{
    yield return null;

    // Hide the physical note
    foreach (Renderer noteRenderer in GetComponentsInChildren<Renderer>())
    {
        noteRenderer.enabled = false;
    }

    gameObject.SetActive(false);
}

    }