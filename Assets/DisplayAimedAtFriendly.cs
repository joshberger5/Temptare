using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayAimedAtFriendly : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        if (PersistentVarHolder.Instance != null)
        {
            this.GetComponent<TextMeshProUGUI>().text += PersistentVarHolder.Instance.aimedAtFriendlyCount.ToString();
        }
        else
        {
            this.GetComponent<TextMeshProUGUI>().text += "0";
        }
    }
}
