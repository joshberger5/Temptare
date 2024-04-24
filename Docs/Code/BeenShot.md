---
title: Been Shot
layout: default
parent: Launch Projectile
nav_order: 2
---

# [Been Shot](https://github.com/joshberger5/Temptare/blob/second/Assets/PersistentVarHolder.cs)
This holds whether the friendly target the script is attached to has been shot already in order to display the warning only one time for each friendly target in the Range scene.

## Variables
```csharp
private bool beenShot = false;
```

## Methods
```csharp
public void setBeenShot() {
    beenShot = true;
}

public bool getBeenShot()
{
    return beenShot;
}
```

