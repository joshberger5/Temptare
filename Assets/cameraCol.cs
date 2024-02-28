using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraCol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Friendly" || collision.gameObject.tag == "Target")
        {
            transform.parent.position = new Vector3(transform.parent.position.x - transform.forward.x, transform.parent.position.y, transform.parent.position.z - transform.forward.z);
        }
    }
}
