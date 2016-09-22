using UnityEngine;
using System.Collections;

public class SmoothingCamera : MonoBehaviour
{

    public Transform target;
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;
    Vector3 targetPosition;
    void Update()
    {
        if (target.transform.rotation.y > 0)
        {
            
             targetPosition = target.TransformPoint(new Vector3(6, 4, 80));
        }
        else if (target.transform.rotation.y == 0)
        {
             targetPosition = target.TransformPoint(new Vector3(6, 4, -80));
        }
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}