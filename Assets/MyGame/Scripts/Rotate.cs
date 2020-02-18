using System.Collections;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float rotSpeed = 20;

    void OnMouseDrag()
    {
        float rotY = Input.GetAxis ("Mouse Y")*rotSpeed*Mathf.Deg2Rad;

        transform.RotateAround(Vector3.right, rotY);
    }

}
