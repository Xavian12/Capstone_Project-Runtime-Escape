using UnityEngine;
using System.Collections;

public class CollectClassroomKey : MonoBehaviour
{
    public GameObject exitKeyButton;

    private bool isCollected = false;

    public void CollectKey()
    {
        if (isCollected)
        {
            return;
        }

        isCollected = true;

        // Add the key to the inventory
        if (exitKeyButton != null)
        {
            exitKeyButton.SetActive(true);
        }

        // Remove the physical key from the classroom
        StartCoroutine(HideKey());
    }

    private IEnumerator HideKey()
    {
        yield return null;
        gameObject.SetActive(false);
    }
}