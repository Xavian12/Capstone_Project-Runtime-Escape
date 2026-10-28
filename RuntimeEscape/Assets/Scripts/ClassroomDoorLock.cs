using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ClassroomDoorLock : MonoBehaviour
{
    public bool IsUnlocked => isUnlocked;
    public XRGrabInteractable leftDoor;
    public XRGrabInteractable rightDoor;
    public ClassroomObjectiveManager objectiveManager;

    private bool isUnlocked = false;

    void Start()
    {
        leftDoor.enabled = false;
        rightDoor.enabled = false;

        leftDoor.GetComponent<Rigidbody>().isKinematic = true;
        rightDoor.GetComponent<Rigidbody>().isKinematic = true;
    }

    public void UnlockDoor()
    {
        if (isUnlocked)
        {
            return;
        }

        isUnlocked = true;

        leftDoor.enabled = true;
        rightDoor.enabled = true;

        leftDoor.GetComponent<Rigidbody>().isKinematic = false;
        rightDoor.GetComponent<Rigidbody>().isKinematic = false;

        if (objectiveManager != null)
        {
            objectiveManager.CompleteChallenge();
        }
    }
}