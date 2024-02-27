using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;

/// <summary>
/// Apply forward force to instantiated prefab
/// </summary>
public class LaunchProjectile : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The projectile that's created")]
    private GameObject projectilePrefab = null;

    [SerializeField]
    [Tooltip("The point that the project is created")]
    private Transform startPoint = null;

    [SerializeField]
    GameObject scoreKeeper = null;

    // keep track of the score
    public static int score = 0;

    // spawn the projectile
    public void Fire()
    {
        GameObject newObject = Instantiate(projectilePrefab, startPoint.position, startPoint.rotation);
    }

    // increase the score
    public static void incScore() {
        score++;
    }

    // decrease the score
    public static void decScore() {
        score--;
    }
    
    // display the score
    void Update()
    {
        scoreKeeper.GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
