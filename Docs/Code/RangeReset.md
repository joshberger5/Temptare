---
title: Range Reset
layout: default
parent: Persistent Variable Holder
nav_order: 1
---

# [Range Reset](https://github.com/joshberger5/Temptare/blob/second/Assets/RangeReset.cs)
This script resets the Range scene's score when the scene is loaded.

## Variables
This script has no variables.

## Methods
```csharp
void Start() // resets the local score on startup of the Range scene
{
    LaunchProjectile.localScore = 0;
}
```

