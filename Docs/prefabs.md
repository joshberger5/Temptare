---
title: Prefabs
layout: home
nav_order: 4
---

# Prefabs
**I plan to add images for nearly all the Prefabs.**

"Prefabs are a special type of component that allows fully configured GameObjects to be saved in the Project for reuse. These assets can then be shared between scenes, or even other projects without having to be configured again." [^1]

### Bullet
- a spherical GameObject that is spawned by the Blaster

### Blaster:
- charcoal grey
- resembles an umbrella handle
- mesh was taken from the Unity VR (Core) Template in Unity Hub
- there is an attach point at the base of the handle where the user will hold it in their hand
- there is a spawn point (Start_Point) for the projectile (bullet)
- has a rigidbody
- has two box colliders to fit the shape of the object
- has the LaunchProjectile script attached
- is an XR grab interactable, so the user can equip it

### Barricade
- 4 white walls to surround the user, with a height of half of the camera's y-position
- each wall has a box collider

### Body
<img id="mainIMG" src="../PrefabImages/BodyPrefab.png"/>
- resembles a (red or green) cardboard cutout of a person 
- 7 cubes:
  - head
  - torso
  - shoulders
  - right arm
  - left arm
  - right leg
  - left leg
- each cube had to have a tag (target or friendly) and a box collider for the bullet collision to work
- two different types: Body F (green) and Body T (red)
<img src="../PrefabImages/BodyPrefabGreen.png"/><img src="../PrefabImages/BodyPrefabRed.png"/>

### Target 
- red cube
- has a box collider
- tag = target
- currently increases the score when shot

### Friendly
- green cube 
- has a box collider
- tag = friendly
- currently decreases the score when shot

### Pole
- pole to hold up the targets, with varying heights

### CameraDirectionChanger
- when the camera collides with this, the camera's direction is set to the direction of this object
- transparent
- has a box collider
- tag = CameraDirectionChanger

### CameraStopper
- when the camera collides with this, the camera's movement is stopped
- transparent
- has a box collider
- tag = CameraStopper

### CameraBodyFlipper
- when the camera collides with this, the nearby bodies (targets) are flipped up
- transparent
- has a box collider
- tag = CameraBodyFlipper

### CameraBodyRaiser
- when the camera collides with this, the nearby bodies (targets) are raised up
- transparent
- has a box collider
- tag = CameraBodyRaiser

### CameraWinInvoker
- when the camera collides with this, the Win scene is loaded
- transparent
- has a box collider
- tag = CameraWinInvoker

### ScoreUI
- transparent canvas
- has two TextMeshPro objects with white text
- the top says, "SCORE"
- the bottom displays the score

### SelfHarmHandler
- a transparent object that is directly behind the user so if they aim at themself, it can be detected
- if it is aimed at, the SuicidePrevention scene is loaded

### WarningCanvas
- a message telling the user not to shoot friendly targets
- spawned above a freindly target if the user shoots it in the Range Scene

----

[^1]: [UnityLearn](https://learn.unity.com/tutorial/prefabs-e#)

<style>
/* image settings, makes images half-sized, so they can go side by side */
img {
    width: 50%;
    height: 50%;
}
#mainIMG {
    height: 100%;
    width: 100%;
}
</style>