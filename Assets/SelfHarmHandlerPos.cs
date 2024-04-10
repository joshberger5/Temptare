using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfHarmHandlerPos : MonoBehaviour
{
    // private Vector3 cameraPos; // holds the position of the camera

    void Start()
    {   
        // cameraPos = UnityEngine.XR.InputTracking.GetLocalPosition(UnityEngine.XR.XRNode.Head); // get the position of the camera
        UnityEngine.XR.InputDevices.GetDeviceAtXRNode(UnityEngine.XR.XRNode.Head).TryGetFeatureValue(UnityEngine.XR.CommonUsages.devicePosition, out Vector3 cameraPos);

        GameObject top = transform.Find("Top").gameObject;
        GameObject back = transform.Find("Back").gameObject;
        top.transform.position = new Vector3(top.transform.position.x, cameraPos.y + 0.25f, top.transform.position.z); // set the top to be at the camera's y-position
        back.transform.localScale = new Vector3(back.transform.localScale.x, cameraPos.y + 0.35f, back.transform.localScale.z); // set the back's height to be from the top's y-position down to the ground
        back.transform.position = new Vector3(back.transform.position.x, (cameraPos.y + 0.35f) / 2, back.transform.position.z); // reposition the back's y-position
    }

    // Update is called once per frame
    void Update()
    {
        // cameraPos = UnityEngine.XR.InputTracking.GetLocalPosition(UnityEngine.XR.XRNode.Head); // get the position of the camera
        UnityEngine.XR.InputDevices.GetDeviceAtXRNode(UnityEngine.XR.XRNode.Head).TryGetFeatureValue(UnityEngine.XR.CommonUsages.devicePosition, out Vector3 cameraPos);

        transform.position = new Vector3(cameraPos.x, 0, cameraPos.z); // make the object follow the GameObject
        // transform.rotation = cameraPos.rotation; // make the object rotate with the GameObject
    }
}
