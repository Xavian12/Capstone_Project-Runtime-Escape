using UnityEngine;

public class PlayerMenuWallCheck : MonoBehaviour
{
    public Transform playerCamera;

    private float normalDistance = 1.2f;

    void LateUpdate()
    {
        if (playerCamera == null)
            return;

        float distance = normalDistance;

        RaycastHit hit;

        if (Physics.Raycast(playerCamera.position,
            playerCamera.forward, out hit, normalDistance))
        {
            distance = Mathf.Max(0.3f, hit.distance - 0.1f);
        }

        transform.localPosition = new Vector3(0, -0.4f, distance);
    }
}