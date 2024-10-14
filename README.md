# Pong-Game-Clone-In-unity

This Unity project is a basic implementation of a Pong-style game with both single-player and two-player modes. Below is a description of the main scripts used in the project.

## Table of Contents
- [Ball.cs](#ballcs)
- [Paddle.cs](#paddlecs)
- [Player1Paddle.cs](#player1paddlecs)
- [Player2Paddle.cs](#player2paddlecs)
- [ComputerPaddle.cs](#computerpaddlecs)
- [GameManager.cs](#gamemanagercs)
- [ScoringZone.cs](#scoringzonecs)
- [ScreenChange.cs](#screenchangecs)
- [How to Run the Game](#how-to-run-the-game)

---

## Ball.cs

This script controls the ball's movement within the game. It handles:
- **Ball movement**: Uses `Rigidbody2D` to add forces and move the ball.
- **Reset position**: Resets the ball to the center after a point is scored.
- **Random starting force**: Adds a random force at the start of each round.

### Methods:
- `ResetPosition()`: Resets the ball's position and velocity.
- `AddStartingForce()`: Applies an initial random force to the ball.
- `AddForce(Vector2 force)`: Adds a custom force to the ball.

---

## Paddle.cs

The base class for all paddles (both player-controlled and AI-controlled). Handles:
- **Basic paddle movement**: Manages movement based on user input or AI logic.
- **Position reset**: Resets the paddle to its starting position after each round.

---

## Player1Paddle.cs and Player2Paddle.cs

These scripts inherit from the `Paddle` class and handle movement for players 1 and 2, respectively. They use Unity's `Input` system to map controls to the paddles.

### Controls:
- **Player 1**: Typically controlled using keyboard inputs (e.g., "W" and "S").
- **Player 2**: Controlled with another set of keys (e.g., "Up" and "Down arrows").

---

## ComputerPaddle.cs

This script controls the AI for a computer-controlled paddle. It tracks the ball's position and adjusts the paddle movement accordingly.

### Key Features:
- Tracks the ball's vertical position and moves the paddle up or down to intercept the ball.
- Moves back to the center when the ball is not heading towards the paddle.

### Methods:
- `FixedUpdate()`: Updates the paddle's position based on the ball's velocity.

---

## GameManager.cs

This script manages the overall game logic, including scorekeeping and resetting the round after a player scores.

### Key Features:
- **Score management**: Updates the score for both players.
- **Round reset**: Resets the ball and paddles after each round.
- **UI updates**: Updates the on-screen text for player scores.

### Methods:
- `Player1Scores()`: Increments Player 1's score and resets the round.
- `Player2Scores()`: Increments Player 2's score and resets the round.
- `ResetRound()`: Resets both paddles and the ball for a new round.

---

## ScoringZone.cs

This script is attached to the scoring zones (goals). It detects when the ball enters a scoring area and triggers the appropriate scoring event.

### Key Features:
- **OnCollisionEnter2D()**: Detects when the ball enters the scoring zone and triggers the appropriate event.

---

## ScreenChange.cs

This script manages the transition between game modes (Single Player and Two Player) by loading different scenes.

### Key Features:
- **Single()**: Loads the single-player mode (scene index 1).
- **Dual()**: Loads the two-player mode (scene index 2).

---

## How to Run the Game

1. Open the project in Unity.
2. Assign the appropriate scenes to the build settings:
   - Scene 1: Single-player mode.
   - Scene 2: Two-player mode.
3. Play the game in the Unity editor or build the project to run it standalone.
4. Use the menu (controlled by the `ScreenChange.cs` script) to select between single-player and two-player modes.
5. Controls for the paddles:
   - Player 1: `W` (up) and `S` (down).
   - Player 2: `Up Arrow` (up) and `Down Arrow` (down).
   - In single-player mode, the AI controls the second paddle.

---

