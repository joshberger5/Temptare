using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField]
    Camera camera;

    // Make the object follow the camera
    void Update()
    {
        transform.position = camera.transform.position + camera.transform.forward * 0.75f; 
        transform.rotation = Quaternion.LookRotation(transform.position - camera.transform.position);
    }
}
