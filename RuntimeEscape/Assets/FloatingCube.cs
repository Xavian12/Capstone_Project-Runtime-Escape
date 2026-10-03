using UnityEngine;

public class FloatingCube : MonoBehaviour
{
    public float floatSpeed = 2f;
    public float floatHeight = 0.25f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}
