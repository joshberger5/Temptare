using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private bool move = false; // boolean holds whether the camera should move

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
            if (transform.parent.position.x == 0 && transform.parent.position.z < 10) 
            {
                transform.parent.Translate(Vector3.forward * Time.deltaTime);
            }
            else {
                transform.parent.Translate(Vector3.right * Time.deltaTime);
            }
        }
    }
}
