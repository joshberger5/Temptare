---
title: Raise Bodies
layout: default
parent: Camera Movement
nav_order: 4
has_children: true
has_toc: false
---

# [Flip Bodies](https://github.com/joshberger5/Temptare/blob/second/Assets/RaiseBodies.cs)
This script makes each body/target in the given array start raising up aboveground by setting raise to true in the body/target's FlipBodyUp script. This script is attached to CameraBodyRaise GameObjects.

## Variables
```csharp
[SerializeField]
private GameObject[] bodies; // array of bodies to raise
```

## Methods
```csharp
public void raise() // raise the bodies
{
    foreach (GameObject body in bodies) // raise each body in the array
    {
        body.GetComponent<RaiseBodyUp>().raise = true;
    }
}
```

