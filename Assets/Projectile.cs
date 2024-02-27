using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // speed the projectile should move
    [SerializeField]
    private float speed = 5.0f;

    // the array of colors to choose from
    [SerializeField]
    private Color[] colors;

    // the renderer for the projectile
    [SerializeField]
    private Renderer renderer;

    // tells if the projectile collided with something
    private bool collided = false;

    // holds the rigidbody of the projectile
    private Rigidbody rb;

    // Start is called before the first frame update
    private void Start()
    {
        // instantiates the rigidbody
        rb = GetComponent<Rigidbody>();

        // randomly assign a color
        renderer.material.color = colors[Random.Range(0, colors.Length - 1)];
    }

    // FixedUpdate is earlier in the order of operations than 
    private void FixedUpdate()
    {
        if (collided) rb.velocity = new Vector3(0, 0, 0);
        else transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    // collision handler
    // destroys projectile on collision with anything other than blaster
    // adds to score if projectile collides with target
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Blaster")
        {
            collided = true;
            Destroy(gameObject);
            if (collision.gameObject.tag == "Target") {
                LaunchProjectile.incScore();
            }
            else if (collision.gameObject.tag == "Friendly") {
                LaunchProjectile.decScore();
            }
        }
    }
}
