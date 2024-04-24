---
title: Display Aimed At Friendly
layout: default
parent: Persistent Variable Holder
grand_parent: Code
nav_order: 3
---

# [Display Aimed At Friendly](https://github.com/joshberger5/Temptare/blob/second/Assets/DisplayAimedAtFriendly.cs)
This script appends the number of times the user aimed at friendly targets in the Training Course scene to the message the script is attached to. This is for the Win scene and the losing scenes.

## Variables
This script has no variables.

## Methods
```csharp
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
```

