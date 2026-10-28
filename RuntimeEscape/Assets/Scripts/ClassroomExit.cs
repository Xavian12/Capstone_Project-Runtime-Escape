using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassroomExit : MonoBehaviour
{
    public ClassroomDoorLock classroomDoor;

    public Transform playerRig;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.root == playerRig && classroomDoor != null
    && classroomDoor.IsUnlocked)
        {
            SceneManager.LoadScene("MenuHallway3D");
        }
    }
}