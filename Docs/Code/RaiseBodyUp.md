---
title: Raise Body Up
layout: default
parent: Raise Bodies
grand_parent: Camera Movement
nav_order: 1
---

# [Raise Body Up](https://github.com/joshberger5/Temptare/blob/second/Assets/RaiseBodyUp.cs)
This script is attached to a body/target and raises it aboveground since it is hidden underground.

## Variables
```csharp
public bool raise = false; // boolean holds whether the body should raise
```

## Methods
```csharp
void Update() // raises the body to be above ground
{   
    if (raise == true && transform.position.y < 0) // if the body is not fully above ground, increase its y-position
    {
        transform.position = new Vector3(
            transform.position.x,
            transform.position.y + 2f * Time.deltaTime,
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
```

