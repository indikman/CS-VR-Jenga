# CS-VR-Jenga
A Jenga game in VR

## Project Setup 

1. Create a new Unity URP Project
2. Window -> Package Manager -> Import XR plugin management
3. Edit -> Project Settings -> Player -> Active input handling -> Both
4. Restart Unity Project
5. Window -> Package Manager -> Advanced -> Enable preview packages
6. Package Manager -> XR Interaction Toolkit
7. Package Manager -> XRI Toolkit Samples
8. Add the left and right input samples to presets
9. Add filters to the presets
10. Edit -> Project Settings -> XR Plugin Management -> Enable Oculus (Android/PC)

## Project Flow

1. In the sample scene, remove all the assets except the Ground
2. Import custom package -> Choose VR Jenga Asset pack
3. Add the skybox
4. Add the table
5. Add the Jenga blocks
6. Create the XR Rig Action based
7. Add the Input System Manager
8. Add the controllers into parent objects
9. Create two more copies of controllers for both left and right each, name them Grab, Push and Teleport
10. Add Grab, Push, Teleport prefabs inside each controller type
11. Setup the controllers to match drag, push and teleport
12. Add Controller Switcher to both, add the objects
13. Open the Input asset, add "Controller Switcher" button to both Left and Right

## Setup Teleport

1. Locomotion System
2. Teleportation Provider
3. Teleportation Area
