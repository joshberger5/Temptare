---
title: Code
layout: default
nav_order: 3
has_children: true
has_toc: false
---
# Code
**I plan to go back and add more notes on the variables and methods, as well as add to Before you look... (Start() and Update())**

## What is a Script and What is it used for?
"Scripts are behavior components that can be applied to GameObjects and modified in the Unity Inspector. A script is made up of C# code that is executed during gameplay. Scripts can also be used to create tools in Unity to modify the development process."[^1]

----

## Before you look at the Scripts
These are some things that show up in the code that may be unfamiliar to you:

### [SerializeField](https://docs.unity3d.com/ScriptReference/SerializeField.html)
SerializeField adds a field in Unity's manual interface to either drag and drop a GameObject or Prefab or manually enter a value for the variable.
```csharp
[SerializeField]
variableType variableName = value;
```

### MonoBehaviour.Start()
The Start() method "is called on the frame when a script is enabled just before any of the Update methods are called the first time."[^2]

### MonoBehaviour.Update()
The Update() method "is called every frame."[^3]

### MonoBehaviour.FixedUpdate()
The FixedUpdate() method is similar to Update(), but it typically happens at a different fequency than once per frame. "The FixedUpdate frequency is more or less than Update. If the application runs at 25 frames per second (fps), Unity calls it approximately twice per frame, Alternatively, 100 fps causes approximately two rendering frames with one FixedUpdate."[^4]

### MonoBehaviour.Awake()
"Unity calls Awake when an enabled script instance is being loaded.

Unity calls Awake on scripts derived from MonoBehaviour in the following scenarios:
* The parent GameObject is active and initializes on Scene load
* The parent GameObject goes from inactive to active
* After initialization of a parent GameObject created with Object.Instantiate

Use Awake to initialize variables or states before the application starts."[^5]

----

[^1]: [UnityLearn](https://learn.unity.com/tutorial/working-with-scripts#)
[^2]: [UnityDocs - Start](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Start.html)
[^3]: [UnityDocs - Update](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html)
[^3]: [UnityDocs - FixedUpdate](https://docs.unity3d.com/ScriptReference/MonoBehaviour.FixedUpdate.html)
[^5]: [UnityDocs - Awake](https://docs.unity3d.com/ScriptReference/MonoBehaviour.Awake.html)