using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipBodyUp : MonoBehaviour
{
    public bool flip = false; // boolean holds whether the body should flip
    void Update() // rotates the body to be upright
    {   
        if (flip == true && transform.rotation.x < 0) // if the body is not upright, rotate it positively over the y-axis
        {
            transform.rotation *= Quaternion.AngleAxis(90 * Time.deltaTime, Vector3.right);
        }
        else if (flip == true && transform.rotation.x > 0) { // if the body went past being upright, set the rotation to be 0 over the y-axis
            transform.localEulerAngles = new Vector3(
                0,
                transform.localEulerAngles.y,
                transform.localEulerAngles.z
            );
        }
    }
}
