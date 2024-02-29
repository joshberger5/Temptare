using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCol : MonoBehaviour
{
    [SerializeField]
    List<string> tags;

    private void OnCollisionEnter(Collision collision)
    {   
        foreach (string tag in tags)
        {
            if (collision.gameObject.tag == tag)
            {
                transform.parent.position = new Vector3(transform.parent.position.x - transform.forward.x, transform.parent.position.y, transform.parent.position.z - transform.forward.z);
            }
        }
    }
}
