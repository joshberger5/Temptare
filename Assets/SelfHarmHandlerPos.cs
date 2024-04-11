using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfHarmHandlerPos : MonoBehaviour
{
    [SerializeField]
    private GameObject camera; // gets the camera to set the rotation, wanted to get the rotation from the input device, but couldn't fix y-rotation

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

    // Crap from prior attempt:
    // UnityEngine.XR.InputDevices.GetDeviceAtXRNode(UnityEngine.XR.XRNode.Head).TryGetFeatureValue(UnityEngine.XR.CommonUsages.deviceRotation, out Quaternion cameraRot);
}
