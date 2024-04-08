using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseBodies : MonoBehaviour
{
    [SerializeField]
    private GameObject[] bodies; // array of bodies to flip

    public void raise() // raises the bodies
    {
        foreach (GameObject body in bodies) // raise each body in the array
        {
            body.GetComponent<RaiseBodyUp>().raise = true;
        }
    }
}
