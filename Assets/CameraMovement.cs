using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private bool move = false; // boolean holds whether the camera should move

    private Vector3 moveDirection = Vector3.forward; // vector3 holds the direction the camera should move

    private int moveAmount = 1; // int holds the amount the camera should move

    public void Move() 
    { 
        // sets move to true
        move = true;
    }

    void Update() 
    {   
        // if move is true, move the camera forward
        if (move)
        {
            transform.parent.Translate(moveDirection * moveAmount * Time.deltaTime);
            /*
            if (transform.parent.position.x == 0 && transform.parent.position.z < 10) 
            {
                transform.parent.Translate(moveDirection * Time.deltaTime);
            }
            else {
                transform.parent.Translate(Vector3.right * Time.deltaTime);
            }
            */
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CameraDirectionChanger") // change the direction of the camera's motion
        {
            moveDirection = other.transform.forward;
        }
        else if (other.gameObject.tag == "CameraStopper") // stop the camera
        {
            moveAmount = 0;
        }
    }
}
