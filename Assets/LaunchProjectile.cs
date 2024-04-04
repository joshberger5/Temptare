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

    public static int score = 0; // the score for the game

    public void Fire() // spawns the projectile
    {
        GameObject newObject = Instantiate(projectilePrefab, startPoint.position, startPoint.rotation);
    }

    public static void incScore() // increases the score
    {
        score++;
    }

    public static void decScore() // decreases the score
    {
        score--;
    }
    
    void Update() // displays the score
    {
        scoreKeeper.GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
