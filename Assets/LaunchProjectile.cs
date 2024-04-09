using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LaunchProjectile : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab = null; // the prefab for the projectile

    [SerializeField]
    private Transform startPoint = null; // where the projectile will be instantiated

    [SerializeField]
    public GameObject scoreKeeper = null;  // the object that displays the score

    public static int localScore = 0; // the local score (mainly for the range scene)

    private float timer = 0f; // the timer to check aiming at friendlies

    void FixedUpdate() {
        timer += Time.deltaTime; // increments the timer
        if (timer >= 1f) // counts the times the user aims at a friendly every second
        {
            RaycastHit hit;
            if (Physics.Raycast(startPoint.position, startPoint.forward, out hit, Mathf.Infinity)) 
            {
                if (hit.collider.gameObject.CompareTag("Friendly") && PersistentVarHolder.Instance != null)
                {
                    PersistentVarHolder.Instance.aimedAtFriendlyCount++;
                }
            }
        }
    }

    public void Fire() // spawns the projectile
    {
        GameObject newObject = Instantiate(projectilePrefab, startPoint.position, startPoint.rotation);
    }
    
    void Update() // displays the score
    {
        if (scoreKeeper != null) 
        {
            if (PersistentVarHolder.Instance != null && SceneManager.GetActiveScene().name != "Range")
            {
                scoreKeeper.GetComponent<TextMeshProUGUI>().text = PersistentVarHolder.Instance.score.ToString();
            }
            else 
            {
                scoreKeeper.GetComponent<TextMeshProUGUI>().text = localScore.ToString();
            }
        }
    }
}
