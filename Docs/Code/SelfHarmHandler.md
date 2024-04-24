---
title: Self Harm Handler Position
layout: default
parent: Camera Movement
grand_parent: Code
nav_order: 5
---

# [Self Harm Handler Position](https://github.com/joshberger5/Temptare/blob/second/Assets/SelfHarmHandlerPos.cs)
This script makes the SelfHarmHandler follow the camera and sets its parts' initial positions and sizes to correspond with those of the user. For example, its top is set to be at the same height as the user's head.

## Variables
```csharp
[SerializeField]
private GameObject camera; // gets the camera to set the rotation, wanted to get the rotation from the input device, but couldn't fix y-rotation
```

## Methods
```csharp
void Start() // initialize the size relative to the camera position
{   
    UnityEngine.XR.InputDevices.GetDeviceAtXRNode(UnityEngine.XR.XRNode.Head).TryGetFeatureValue(UnityEngine.XR.CommonUsages.devicePosition, out Vector3 cameraPos); // get the device's position

    GameObject top = transform.Find("Top").gameObject;
    GameObject back = transform.Find("Back").gameObject;
    top.transform.position = new Vector3(top.transform.position.x, cameraPos.y + 0.25f, top.transform.position.z); // set the top to be at the device's y-position
    back.transform.localScale = new Vector3(back.transform.localScale.x, cameraPos.y + 0.35f, back.transform.localScale.z); // set the back's height to be from the top's y-position down to the ground
    back.transform.position = new Vector3(back.transform.position.x, (cameraPos.y + 0.35f) / 2, back.transform.position.z); // recenter the back on the y-axis
}

void Update() // make the object follow the camera and replicate its rotation
{
    transform.position = new Vector3(camera.transform.position.x, 0, camera.transform.position.z); // make the object follow the camera
    transform.rotation = Quaternion.LookRotation(new Vector3(camera.transform.forward.x, 0, camera.transform.forward.z), Vector3.up); // make the object rotate with the camera
}
```

