---
title: Display Final Score
layout: default
parent: Persistent Variable Holder
nav_order: 4
---

# [Display Final Score](https://github.com/joshberger5/Temptare/blob/second/Assets/DisplayFinalScore.cs)
This script appends the score from the Training Course scene to the message the script is attached to. This is for the Win scene and the losing scenes.

## Variables
This script has no variables.

## Methods
```csharp
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
```

