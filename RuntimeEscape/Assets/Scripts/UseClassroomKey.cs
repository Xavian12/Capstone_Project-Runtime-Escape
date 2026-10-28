using UnityEngine;

public class UseClassroomKey : MonoBehaviour
{
    public Transform player;
    public Transform classroomDoor;
    public ClassroomDoorLock doorLock;
    public InventoryNoteDisplay noteDisplay;

    public float unlockDistance = 3f;

    public void UseKey()
    {
        if (noteDisplay != null && noteDisplay.noteDescription != null)
        {
            noteDisplay.noteDescription.text = "";
        }
        float distance = Vector3.Distance(player.position, classroomDoor.position);

        if (distance <= unlockDistance)
        {
            doorLock.UnlockDoor();
        }
        else
        {
            Debug.Log("Move closer to the classroom doors to use the key.");
        }
    }
}