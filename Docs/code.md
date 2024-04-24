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
Something that shows up regularly in the code that you might be unfamiliar with is:
```csharp
[SerializeField]
variableType variableName = value;
```
[SerializeField](https://docs.unity3d.com/ScriptReference/SerializeField.html) adds a field in Unity's manual interface to either drag and drop a GameObject or Prefab or manually enter a value for the variable.

----

[^1]: [UnityLearn](https://learn.unity.com/tutorial/working-with-scripts#)