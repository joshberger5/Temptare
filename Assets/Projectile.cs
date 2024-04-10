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

    [SerializeField]
    private GameObject warning; // the prefab for the warning display when a friendly is hit

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // initialize the rigidbody
        renderer.material.color = colors[Random.Range(0, colors.Length - 1)]; // randomly assign a color

        ignoreCollisions(GameObject.FindGameObjectsWithTag("Blaster")); // ignore collisions with GameObjects of certain tags
        ignoreCollisions(GameObject.FindGameObjectsWithTag("CameraStopper"));
        ignoreCollisions(GameObject.FindGameObjectsWithTag("CameraBodyFlipper"));
        ignoreCollisions(GameObject.FindGameObjectsWithTag("CameraDirectionChanger"));
        ignoreCollisions(GameObject.FindGameObjectsWithTag("CameraBodyRaiser"));
        ignoreCollisions(GameObject.FindGameObjectsWithTag("CameraWinInvoker"));
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
        if (collision.gameObject.tag == "Target") { // increase the score if the projectile hits a target
            if (PersistentVarHolder.Instance != null && SceneManager.GetActiveScene().name != "Range") // don't affect the persistent score in the range scene
            {
                PersistentVarHolder.Instance.score++;
            }
            else
            {
                LaunchProjectile.localScore++;
            }
        }
        else if (collision.gameObject.tag == "Friendly") { // go to the ShotFriendly scene if the projectile hits a friendly
            if (SceneManager.GetActiveScene().name != "Range") // don't switch scenes in the range scene
            {
                SceneManager.LoadScene("ShotFriendly");
            }
            else { // create a warning display if the projectile hits a friendly in the range scene
                if (collision.gameObject.GetComponent<BeenShot>() != null && !collision.gameObject.GetComponent<BeenShot>().getBeenShot()) // if the friendly has not been shot before, create a warning display
                {
                    Vector3 wPos = new Vector3(collision.transform.position.x, collision.transform.position.y + 1, collision.transform.position.z);
                    GameObject newObject = Instantiate(warning, wPos, Quaternion.LookRotation(Vector3.forward, Vector3.up));
                    collision.gameObject.GetComponent<BeenShot>().setBeenShot();
                }
            }
        }
        else if (collision.gameObject.tag == "ScenePicker") {  // switch scenes if the projectile hits a ScenePicker
            SceneManager.LoadScene(collision.gameObject.name);
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(collision.gameObject.name));
        }
    }
}
