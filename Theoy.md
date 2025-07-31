Theory Notes for Cube Runner 3D
GameObject
Every visible (cube, obstacle, pickup) and invisible (spawn point, finish line) entity in Cube Runner 3D is a GameObject. Organizing elements this way helps keep levels structured and allows attaching custom behaviors.

Component
Components are what give GameObjects their capabilities:

Transform (built-in): Every GameObject has one to manage its position along the runner track.

Collider: Cubes and obstacles have Colliders for collision detection—so the game knows when you hit something!

Rigidbody: Used for physically correct movement and jumping behavior, especially for the player cube.

Script: Controls things like player movement, obstacle spawning, and score logic.

Scene
Each level of Cube Runner 3D is a Scene. Scenes typically may contain:

A starting platform and finish line.

Layout of obstacle and pickup prefabs.

Cameras and light setup for consistent visual style.

UI elements (like score or health bar).

Unity’s Scene system allows separating menu screens, levels, and game-over screens into different assets.

Script
In your game, custom C# scripts do the heavy lifting:

PlayerController.cs: Handles input and movement.

ObstacleManager.cs: Spawns and (optionally) recycles obstacles for new levels.

GameManager.cs: Coordinates game start, progression, win/lose state, and score tracking.

In MonoBehaviour scripts, you’ll frequently use Start(), Update(), OnCollisionEnter() to control game logic on a per-frame or on-collision basis.

Prefab
Prefabs let you reuse complex designs. In Cube Runner 3D:

The player cube, obstacles, pickups, and even UI panels may all be prefabs.

Editing a prefab updates all placed copies across every scene—saving massive time.

You can design an obstacle once and instantiate it multiple times per level, even randomizing appearance or movement in scripts.

Physics
Physics gives jumping, collision, and obstacle interactions their feel:

Rigidbody is what lets the cube jump and fall naturally with gravity.

Collider on obstacles and pickups ensures the game detects hits, losses, or pickups.

Adjusting mass, drag, and gravity settings changes how the cube responds to input.

Camera
Follow Camera: Often implemented via a script or Cinemachine to track the cube from behind or above, matching its forward progress and making the game visually smooth.

Camera scripts may add shake effects on collision or change field-of-view for speed and intensity.

Input Handling
Keyboard Input: You likely use Input.GetKey or Input.GetAxis to read left/right arrow or A/D key movement, and spacebar for jumps.

Touch Input: (If you add mobile support in the future.)

The input is processed each frame in your player controller script and then directly affects the cube’s Rigidbody or transform.

UI Elements
Canvas and UI: Manages score display, level number, pause menu, and win/lose screens.

Text: Shows current score, high score, and instructions.

UI events may trigger script methods, such as restarting the level or returning to the main menu.

Game Loop
Each play session follows this classic flow:

Scene loads; player cube spawns at start.

User input moves the cube; obstacles are spawned or placed along the track.

Collisions with obstacles can end the game; reaching the finish line triggers level complete.

UI reflects the current state (score, win/loss, next level).

Level Design
Increasing Difficulty is achieved by placing more obstacles, narrowing paths, or making moving obstacles.

Level progression can be via scene loading or activating different GameObjects for staging.

Optimization
Object Pooling: For obstacle or pickup reuse instead of destroying/instantiating repeatedly (improves performance for mobile/low-end devices).

Baking Lighting: Improves runtime performance and keeps levels visually consistent.

Version Control
Using Git with a .gitignore that excludes Library, Temp, and Build folders keeps your repo clean and focused only on the assets, scripts, and data required to build and edit the game.

All scripts, scenes, prefabs, and the Theory.md itself should be tracked in your repository.

Additional Concepts Related to Your Runner Game
Checkpoint System: Could let players restart from midpoints within a level (optional advanced feature).

Pickup System: Explains the logic behind pickups (e.g., increasing score, health, or unlocking new skins).

Sound and Music: Using AudioSource components for background music, jump sounds, or obstacle collision effects.

Player Customization: If you allow changing the color/skin of the player cube, explain how to do that via materials and scripts.