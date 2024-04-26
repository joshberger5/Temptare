---
title: Raise Bodies
layout: default
parent: Code
nav_order: 9
---

![](./CameraMovementHierarchy.png)
# [Raise Bodies](https://github.com/joshberger5/Temptare/blob/second/Assets/RaiseBodies.cs)
This script makes each [body/target](../prefabs.html#body) in the given array start raising up aboveground by setting raise to true in the body/target's [RaiseBodyUp](./RaiseBodyUp.html) script. This script is attached to [CameraBodyRaiser](../prefabs.html#cameracolliders) GameObjects.

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

