# YellowJacket Escape - A 2D Dungeon Crawler

## 🎮 Project Overview
**YellowJacket Escape** is a top-down 2D dungeon crawler where the player, controlling a small character, must navigate through hazardous environments while avoiding or confronting YellowJacket enemies. The game emphasizes strategic movement, enemy interactions, and survival mechanics.

## 🚀 Features
- **Tilemap-based level design** using Unity's Tilemap system.
- **Player Movement System** allowing free movement across the grid.
- **Enemy AI** with:
  - **Melee Enemies** that kill the player on contact.
  - **Ranged Enemies** that shoot projectiles at the player.
- **Combat & Damage System**:
  - The player dies after two projectile hits.
  - Melee enemies instantly kill the player upon collision.
- **Prefabs for Modularity**:
  - Easily add more enemy types and behaviors.
  - Scalable system for attacks, movement, and AI.
- **Basic Debugging & Logging** to track player and enemy interactions.

## 🛠 Technologies Used
- **Game Engine**: Unity 6 (Universal 2D Template)
- **Programming Language**: C#
- **Version Control**: Git & GitHub

## 📂 Project Structure
```
YellowJacketEscape/
│── Assets/
│   ├── Materials/
│   ├── Prefabs/
│   │   ├── Player.prefab
│   │   ├── YellowJacket.prefab
│   │   ├── Projectile.prefab
│   ├── Scenes/
│   ├── Scripts/
│   │   ├── Enemy Scripts/
│   │   │   ├── EnemyAI.cs
│   │   │   ├── MeleeAttack.cs
│   │   │   ├── RangedAttack.cs
│   │   ├── Player Scripts/
│   │   │   ├── PlayerMovement.cs
│   │   │   ├── PlayerHealth.cs
│   ├── Sprites/
│── README.md
```

## 🎮 How to Play
1. **Move** the player using the keyboard (WASD or Arrow Keys).
2. **Avoid or fight enemies**:
   - Melee enemies will kill you instantly.
   - Ranged enemies will shoot projectiles at you.
3. **Survive** as long as possible while exploring the map.
4. **Game Over** occurs when you are hit by 2 projectiles or collide with a melee enemy.

## 🔧 Setup Instructions
1. **Clone the Repository**
   ```sh
   git clone https://github.com/yourusername/yellowjacket-escape.git
   cd yellowjacket-escape
   ```
2. **Open in Unity**:
   - Open Unity Hub and select `YellowJacketEscape`.
3. **Run the Game**:
   - Click `Play` in Unity’s Editor to start testing.

## 👾 Future Improvements
- Add **pathfinding for enemies** (NavMesh or A* Algorithm).
- Implement **waypoints for enemy patrols**.
- Introduce **power-ups & collectibles**.
- Expand levels with **dynamic tilemaps**.


🚀 *Enjoy escaping the YellowJackets!*

