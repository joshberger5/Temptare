using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private float speed; // the speed the projectile should move

    [SerializeField]
    private Color[] colors; // the array of colors to choose from

    [SerializeField]
    private Renderer renderer; // the renderer for the projectile

    private Rigidbody rb; // holds the rigidbody of the projectile

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // initialize the rigidbody
        renderer.material.color = colors[Random.Range(0, colors.Length - 1)]; // randomly assign a color

        ignoreCollisions(GameObject.FindGameObjectsWithTag("Blaster")); // ignore collisions with GameObjects of certain tags
        ignoreCollisions(GameObject.FindGameObjectsWithTag("CameraStopper"));
        ignoreCollisions(GameObject.FindGameObjectsWithTag("CameraBodyFlipper"));
        ignoreCollisions(GameObject.FindGameObjectsWithTag("CameraDirectionChanger"));
    }

    private void ignoreCollisions(GameObject[] ignoreThese) // ignore collisions with certain GameObjects
    {
        foreach (GameObject g in ignoreThese)
        {
            Physics.IgnoreCollision(g.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); // move the projectile forwards
    }

    private void OnCollisionEnter(Collision collision) // collision handler
    {
        Destroy(gameObject);
        if (collision.gameObject.tag == "Target") { // increase score if the projectile hits a target
            LaunchProjectile.incScore();
        }
        else if (collision.gameObject.tag == "Friendly") { // decrease score if the projectile hits a friendly
            SceneManager.LoadScene("ShotFriendly");
        }
        else if (collision.gameObject.tag == "ScenePicker") {  // switch scenes if the projectile hits a ScenePicker
            SceneManager.LoadScene(collision.gameObject.name);
        }
    }
}
