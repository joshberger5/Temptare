using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCol : MonoBehaviour
{
    [SerializeField]
    List<string> tags;  // the tags of objects the camera should collide with

    Vector3 lastPosition; // holds the previous position of the camera

    private void Start() {
        lastPosition = transform.position; // initializes the previous position
    }

    private void Update() {
        if (Vector3.Distance(transform.position, lastPosition) > 0.1f) 
        {
            lastPosition = transform.position; // if the camera has moved more than 0.1 units, update the previous position
        }
    }

    private void OnCollisionEnter(Collision collision)
    {   
        foreach (string tag in tags)
        {
            if (collision.gameObject.tag == tag)
            {   
                Vector3 difference = transform.position - lastPosition; // when the camera collides with something, move it back to the previous position
                difference.y = 0;
                transform.parent.position -= difference;
            }
        }
    }
}
