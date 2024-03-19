using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionDestroy : MonoBehaviour
{
    [SerializeField]
    GameObject camera;

    private void OnCollisionEnter(Collision collision) 
    {
        // when this object collides with another object, start the camera's movement
        camera.GetComponent<CameraMovement>().Move();
        Destroy(gameObject);
    }
}
