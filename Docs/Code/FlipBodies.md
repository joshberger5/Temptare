---
title: Flip Bodies
layout: default
parent: Code
nav_order: 7
---

# [Flip Bodies](https://github.com/joshberger5/Temptare/blob/second/Assets/FlipBodies.cs)
This script makes each body/target in the given array start flipping up by setting flip to true in the body/target's FlipBodyUp script. This script is attached to CameraBodyFlipper GameObjects.

## Variables
```csharp
[SerializeField]
private GameObject[] bodies; // array of bodies to flip
```

## Methods
```csharp
public void flip() // flips the bodies
{
    foreach (GameObject body in bodies) // flip each body in the array
    {
        body.GetComponent<FlipBodyUp>().flip = true;
    }
}
```

