using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentVarHolder : MonoBehaviour
{
    // I got this from:
    // https://learn.unity.com/tutorial/implement-data-persistence-between-scenes#634f8281edbc2a65c86270cb
    
    public static PersistentVarHolder Instance;

    public int score = 0; // holds the score for the game

    public int aimedAtFriendlyCount = 0; // holds the number of times the user aimed at a friendly

    private void Awake()    // makes sure that there is only one instance of this object
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
