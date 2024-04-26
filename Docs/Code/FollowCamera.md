---
title: Follow Camera
layout: default
parent: Code
nav_order: 6
---

![](./CameraMovementHierarchy.png)
# [Follow Camera](https://github.com/joshberger5/Temptare/blob/second/Assets/FollowCamera.cs)
This script makes the object perpetually stay in front of and face the [camera](../prefabs.html#xr-origin-xr-rig), it was made to display the [score](../prefabs.html#scoreui) in front of the user for the [Range](../Scenes/range.html) and [Training Course](../Scenes/trainingCourse.html) scenes.

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

