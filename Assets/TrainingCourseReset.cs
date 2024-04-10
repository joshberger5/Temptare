using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingCourseReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() // resets the score and the number of times the player aimed at a friendly on startup of the TrainingCourse scene
    {
        PersistentVarHolder.Instance.score = 0;
        PersistentVarHolder.Instance.aimedAtFriendlyCount = 0;
    }
}
