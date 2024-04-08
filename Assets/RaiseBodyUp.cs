using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseBodyUp : MonoBehaviour
{
    public bool raise = false; // boolean holds whether the body should raise
    void Update() // raises the body to be above ground
    {   
        if (raise == true && transform.position.y < 0) // if the body is not fully above ground, increase its y-position
        {
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y + 1 * Time.deltaTime,
                transform.position.z
            );
        }
        else if (raise == true && transform.position.y > 0) { // if the body is fully above ground, make sure it is at 0
            transform.position = new Vector3(
                transform.position.x,
                0,
                transform.position.z
            );
        }
    }
}
