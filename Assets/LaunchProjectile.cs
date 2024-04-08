using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;

public class LaunchProjectile : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab = null; // the prefab for the projectile

    [SerializeField]
    private Transform startPoint = null; // where the projectile will be instantiated

    [SerializeField]
    GameObject scoreKeeper = null;  // the object that displays the score

    void FixedUpdate() {
        RaycastHit hit; // counts the times the user aims at a friendly
        if (Physics.Raycast(startPoint.position, startPoint.forward, out hit, Mathf.Infinity)) 
        {
            if (hit.collider.gameObject.CompareTag("Friendly"))
            {
                PersistentVarHolder.Instance.aimedAtFriendlyCount++;
            }
        }
    }

    public void Fire() // spawns the projectile
    {
        GameObject newObject = Instantiate(projectilePrefab, startPoint.position, startPoint.rotation);
    }

    public static void incScore() // increases the score
    {
        PersistentVarHolder.Instance.score++;
    }

    public static void decScore() // decreases the score
    {
        PersistentVarHolder.Instance.score--;
    }
    
    void Update() // displays the score
    {
        if (scoreKeeper != null)
        {
            scoreKeeper.GetComponent<TextMeshProUGUI>().text = PersistentVarHolder.Instance.score.ToString();
        }
    }
}
