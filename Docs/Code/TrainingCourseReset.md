---
title: Training Course Reset
layout: default
parent: Code
nav_order: 14
---

![](./PersistentVarHolderHierarchy.png)
# [Training Course Reset](https://github.com/joshberger5/Temptare/blob/second/Assets/TrainingCourseReset.cs)
This script resets the [Training Course](../Scenes/trainingCourse.html) scene's score when the scene is loaded.

## Variables
This script has no variables.

## Methods
```csharp
void Start() // resets the score and the number of times the player aimed at a friendly on startup of the TrainingCourse scene
{
    PersistentVarHolder.Instance.score = 0;
    PersistentVarHolder.Instance.aimedAtFriendlyCount = 0;
}
```

