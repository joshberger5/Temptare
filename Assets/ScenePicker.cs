using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePicker : MonoBehaviour
{
    [SerializeField]
    private string scene; // holds the name of the scene to go to

    private void onCollisionEnter(Collision collision) // when the object is shot, move to that scene
    {
        Debug.Log("Scene Loaded");
        if (collision.gameObject.tag == "Bullet")
        {
            SceneManager.LoadScene(scene);
        }
    }
}
