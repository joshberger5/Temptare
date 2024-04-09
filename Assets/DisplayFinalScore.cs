using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayFinalScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        if (PersistentVarHolder.Instance != null)
        {
            this.GetComponent<TextMeshProUGUI>().text += PersistentVarHolder.Instance.score.ToString();
        }
        else
        {
            this.GetComponent<TextMeshProUGUI>().text += "0";
        }
    }
}
