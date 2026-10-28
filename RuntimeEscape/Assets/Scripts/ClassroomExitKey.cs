using UnityEngine;

public class ClassroomExitKey : MonoBehaviour
{
    public ClassroomDoorLock doorLock;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ExitKey"))
        {
            if (doorLock != null)
            {
                doorLock.UnlockDoor();
            }
        }
    }
}