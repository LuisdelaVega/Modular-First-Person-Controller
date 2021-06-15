# Modular First Person Controller

This package contains modular, first person controller with basic capabilities (character movement, camera aiming, gravity & basic jumping), that is easily modifiable to your needs.

The Input Actions are currently rigged to work with Keyboard/Mouse and Gamepads.

## How to expand upon it

[EXAMPLE] Adding new movement via player input (i.e. a Dash or a Double Jump):

1. Add a new _Action_ to the **Input Actions**.
2. Create a handler class that inherits from `MovementModifier` and implements the `IInputProcessor` inteface.
   - `MovementModifier` implements a very simple interface called `IMovementModifier`.
   - A list of enabled Movement Modifiers is kept by the `MovementHandler` class, which adds up all of the values for these Movement Modifiers and excecutes them using the `Move` method for the **Character Controller** Component.
3. Write the code for your desired movement behavior. (Following the structure of the classes in the _Input Processors_ folder should help.)
4. Add your newly created class to the **First Person Player** as a Component.
5. Assign the event in the **Player Input** Component in the **First Person Player** prefab.

## Dependencies

### Hard Dependencies

These are a must for this package to work properly:

- [Input System: ^1.0.2](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/manual/QuickStartGuide.html)

### Soft Dependencies

These are nice to have but the package can work without them with minimal changes:

- [Cinemachine: ^2.7.4](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.7/manual/index.html)
