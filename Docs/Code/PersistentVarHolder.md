---
title: Persistent Variable Holder ●
layout: default
parent: Code
nav_order: 12
---

![](./PersistentVarHolderHierarchy.png)
# [Persistent Variable Holder](https://github.com/joshberger5/Temptare/blob/second/Assets/PersistentVarHolder.cs)
This script is a [Singleton](https://refactoring.guru/design-patterns/singleton/csharp/example#:~:text=Singleton%20is%20a%20creational%20design,the%20modularity%20of%20your%20code.) that holds the variables that should keep their values from scene to scene. It is meant to keep the score and number of times the user aimed at friendly targets during the [Training Course](../Scenes/trainingCourse.html) scene so they can be displayed when you are taken to the Win scene or one of the losing scenes.

I modified the code from [this tutorial](https://learn.unity.com/tutorial/implement-data-persistence-between-scenes#634f8281edbc2a65c86270cb).

## Variables
```csharp
public static PersistentVarHolder Instance;

public int score = 0; // holds the score for the game

public int aimedAtFriendlyCount = 0; // holds the number of times the user aimed at a friendly
```

## Methods
```csharp
private void Awake() // makes sure that there is only one instance of this object
{
    if (Instance != null)
    {
        Destroy(gameObject);
        return;
    }

    Instance = this;
    DontDestroyOnLoad(gameObject);
}
```

