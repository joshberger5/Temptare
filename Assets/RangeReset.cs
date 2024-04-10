using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeReset : MonoBehaviour
{
    void Start() // resets the local score on startup of the Range scene
    {
        LaunchProjectile.localScore = 0;
    }
}
