using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipBodies : MonoBehaviour
{
    [SerializeField]
    private GameObject[] bodies; // array of bodies to flip

    public void flip() // flips the bodies
    {
        foreach (GameObject body in bodies) // flip each body in the array
        {
            body.GetComponent<FlipBodyUp>().flip = true;
        }
    }
}
