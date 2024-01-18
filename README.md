# Helix Jump 3D

Welcome to the Helix Jump 3D game repository! In this Unity game, players navigate a helix structure, bouncing off platforms, and aiming to reach the bottom while avoiding obstacles. Let's get into the details.

## Table of Contents

- [Overview](#overview)
- [Game Mechanics](#game-mechanics)
- [How to Play](#how-to-play)
- [Scripts](#scripts)
- [Contributing](#contributing)
- [License](#license)

## Overview

Helix Jump 3D offers an exciting and challenging gaming experience, where players control a bouncing ball through a helix structure. The goal is to navigate through rings, avoid obstacles, and progress to the next level. With smooth controls, vibrant visuals, and dynamic sound effects, Helix Jump 3D keeps players engaged and entertained.

## Game Mechanics

The game includes the following key mechanics:

- **Rotator:**
  - The helix structure rotates based on mouse movement, providing a dynamic and interactive environment.

- **Ring:**
  - Rings within the helix trigger scoring and level progression when the player successfully passes through them.

- **Player:**
  - The player's ball bounces off platforms, with different materials affecting gameplay.
  - Collisions with unsafe materials lead to game over, while collisions with lit materials signify level completion.

- **Game Manager:**
  - Manages the overall game state, including tracking levels, handling game over and level completion, and updating the score.

- **UI and Interaction:**
  - UI elements display the current level, next level, progress slider, and score.
  - Players can toggle mute, quit the game, and interact with start menus.

## How to Play

1. **Navigate the Helix:**
   - Use mouse movement to rotate the helix structure and guide the ball through rings.

2. **Bounce and Score:**
   - The ball automatically bounces off platforms.
   - Passing through rings scores points and progresses through levels.

3. **Avoid Obstacles:**
   - Colliding with unsafe materials leads to game over.

4. **Complete Levels:**
   - Successfully passing through lit materials signifies level completion.

5. **UI Interaction:**
   - Toggle mute, quit the game, and navigate start menus using on-screen buttons.

## Scripts

### 1. `Rotator.cs`

Handles the rotation of the helix structure based on mouse movement.

### 2. `Ring.cs`

Triggers scoring and level progression when the player passes through rings.

### 3. `Player.cs`

Manages the player's ball behavior, including bouncing, collision detection, and material interactions.

### 4. `OnClickEvent.cs`

Handles UI interactions, allowing players to toggle mute, quit the game, and navigate menus.

### 5. `HelixManager.cs`

Manages the spawning of helix rings, setting up the initial rings, and updating the helix structure.

### 6. `GameManager.cs`

Controls the overall game state, including tracking levels, handling game over and level completion, and updating the score.

### 7. `CharacterSelector.cs`

Enables players to change the appearance of their character.

### 8. `CameraFollow.cs`

Ensures smooth camera following of the player's ball.

### 9. `AudioManager.cs`

Manages audio elements, including playing various sounds throughout the game.

## Contributing

If you're interested in contributing to Helix Jump 3D, follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them.
4. Push to your fork and submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE), allowing for both personal and commercial use.

Feel free to reach out with any questions, feedback, or suggestions.

Enjoy playing and developing Helix Jump 3D!
