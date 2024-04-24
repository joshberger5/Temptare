---
title: Follow Camera
layout: default
parent: Camera Movement
nav_order: 2
---

# [Follow Camera](https://github.com/joshberger5/Temptare/blob/second/Assets/FollowCamera.cs)
This script makes the object perpetually stay in front of and face the camera, it was made to display the score in front of the user for the Range and Training Course scenes.

## Variables
```csharp
[SerializeField]
Camera camera; // the camera to follow
```

## Methods
```csharp
// Make the object follow and face the camera
void Update()
{
    transform.position = camera.transform.position + camera.transform.forward * 0.75f; 
    transform.rotation = Quaternion.LookRotation(transform.position - camera.transform.position);
}
```

