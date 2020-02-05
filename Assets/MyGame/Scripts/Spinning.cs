using UnityEngine;

public class Spinning : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField, Range(-10f, 10f)] float rotationSpeed;

    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0, Space.World);
    }
}
