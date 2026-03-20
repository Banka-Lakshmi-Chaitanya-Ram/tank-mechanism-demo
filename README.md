# Tank Mechanism Demo (Unity)

This is a **beginner-level Unity project** I built to practice basic game mechanics like movement, aiming, and shooting.

The goal of this project was **learning and experimentation**, not building a complete game.

---

## 🔧 What this project includes

* Tank movement using keyboard input
* Tank rotation
* Turret aiming using mouse (raycasting)
* Shooting bullets from the tank
* Simple camera follow system
* Basic ground and collision setup

---

## 📸 Screenshots

Screenshots are stored inside the

`Assets/
Screenshots/
    gameplay.png
    aiming.png`

folder in this repository.


---

## 📂 Project Structure (important)

* `Assets/` → Unity project files
* `ProjectSettings/` → Unity settings
* `Screenshots/` → Images used in this README

---

## ▶️ How to run

### Option 1 — Using Unity

1. Clone or download this repository
2. Open **Unity Hub**
3. Click **Add Project**
4. Select this folder
5. Open and press ▶️ Play

---

### Option 2 — Build (if added)

If a build is available in the repo, you can download and run it directly without Unity.

---

## ⚠️ Issues I faced (learning part)

This project helped me understand some common beginner problems:

### 1. Axis confusion (main issue)

* Unity uses **Z axis as forward**
* My tank model was aligned differently (X direction)
* Because of that:

  * Movement felt sideways
  * Turret rotation behaved incorrectly
* I adjusted the code instead of fixing the model orientation

---

### 2. Camera positioning issues

* Camera initially followed only one axis
* Result: weird movement and wrong positioning
* Fixed by updating position using both X and Z

---

### 3. Component assignment errors

* Faced `UnassignedReferenceException`
* Learned that Unity requires manual linking in Inspector (e.g., tankTower, aimTransform)

---

### 4. Git & large file issues

* Initially pushed unnecessary Unity folders like `Library/`
* Faced large file errors on GitHub
* Fixed using `.gitignore`

---

## 📌 What I learned

* Basics of Unity Transform and Rigidbody
* Handling keyboard input
* Raycasting for mouse aiming
* Structuring scripts (Update vs FixedUpdate)
* Basic Git workflow for Unity projects

---

## 🎯 Project status

✔ Completed as a practice/demo project
✔ Built for understanding Unity basics

---

## 👨‍💻 Author

Banka Lakshmi Chaitanya Ram
(Beginner Unity Project)
