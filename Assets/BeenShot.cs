using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeenShot : MonoBehaviour
{
    private bool beenShot = false;

    public void setBeenShot() {
        beenShot = true;
    }

    public bool getBeenShot()
    {
        return beenShot;
    }
}
