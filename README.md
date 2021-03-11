# Spaceship Simulator

A 3D space flight simulation game that enables users to control a spaceship in a 3D environment. Provide the functionalities for the user to interact with the environment and control the movement of the spacecraft.

## Requirements

* Unity 2019.3
* Android Build Support 
  * Android SDK & NDK Tools
  * OpenJDK
* Android Phone (Minimum API Level 19)

## Installation

Clone the repository and open it with the Unity Hub. Connect your device with the development machine and enable USB debugging. Click on the 'Play' button to install the application and run it on your connected device.

## User Manual

1. Launch the application if the app has been installed on the device
1. Click on the 'Play' button on the main menu
1. Click on the top right toggle button to enable the spaceship movement
1. Control the spaceship heave motion with 'Up' and 'Down' buttons
1. Rotate the spaceship with 'Left' and 'Right' buttons
1. Control the spaceship movement with the joystick at the left side corner
1. Move the spacecraft to the target destination by following the directional arrow
1. Pause and quit the application by click on the 'Pause' and 'Quit' buttons

## Application Creation Steps

1. Download and install the software required
    * Unity with Android Build Support platform module
    * Autodesk Maya
1. Create the game objects with Autodesk Maya
    * Spacecraft
    * Spaceship Station
    * Directional Arrow
1. Create a new Unity project with the Android platform selected
1. Add the required resources to the asset folders
    * Animations
    * Audio
    * Images
    * Fonts
1. Create the menu and game scenes
    * Menu Scene
      1. Design the user interface with the canvas
      1. Add the change scene function to the 'Play' button
      1. Add the color modification function
      1. Add the setting menu to allow the user to change the graphic and adjust the volume
    * Game Scene
      1. Import the Maya objects created into the Unity
      1. Implement the controller with touch gesture to control the spaceship movement
      1. Create the functions to continue spawning the station when the destination arrived
1. Test and debug the application using the connected device
1. Configure the project build settings and build the project
1. Install the generated apk file on the device
1. Launch the application

## Credits

* [DitzelGames](https://www.youtube.com/watch?v=8ycgJbQegAo), Touch Third Person Character Controller in Unity 2018
