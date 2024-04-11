using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMovement : MonoBehaviour
{
    private bool move = false; // boolean holds whether the camera should move

    private Vector3 moveDirection = Vector3.forward; // vector3 holds the direction the camera should move

    private float moveAmount = 1.5f; // int holds the amount the camera should move

    [SerializeField]
    private GameObject[] blasters; // holds the blasters in the scene

    public void Move() // sets move to true
    { 
        move = true;
    }

    void Update() // if move is true, move the camera the direction held in moveDirection
    {   
        if (move)
        {
            transform.parent.Translate(moveDirection * moveAmount * Time.deltaTime);
            foreach (GameObject blaster in blasters)
            {
                bool isHoldingAtLeastOneBlaster = false;
                if (blaster.GetComponent<LaunchProjectile>() != null && blaster.gameObject.GetComponent<LaunchProjectile>().getIsHeld())
                {
                    isHoldingAtLeastOneBlaster = true;
                }
                if (!isHoldingAtLeastOneBlaster)
                {
                    SceneManager.LoadScene("DroppedBlasters");
                }
            }
        }   
    }

    private void OnTriggerEnter(Collider other) // if the camera hits a trigger, modify the camera's movement
    {
        if (other.gameObject.tag == "CameraDirectionChanger") // if it hits a CameraDirectionChanger, then change the direction of the camera's motion
        {
            moveDirection = other.transform.forward;
        }
        else if (other.gameObject.tag == "CameraStopper") // if it hits a CameraStopper, then stop the camera
        {
            moveAmount = 0;
        }
        else if (other.gameObject.tag == "CameraBodyFlipper") // if it hits a CameraBodyFlipper, then rotate the nearby bodies
        {
            other.gameObject.GetComponent<FlipBodies>().flip();
        }
        else if (other.gameObject.tag == "CameraBodyRaiser") // if it hits a CameraBodyRaiser, then raise the nearby bodies
        {
            other.gameObject.GetComponent<RaiseBodies>().raise();
        }
        else if (other.gameObject.tag == "CameraWinInvoker") // if it hits a CameraWinInvoker, then jump to the win scene
        {
            SceneManager.LoadScene("Win");
        }
    }
}
