# Modular First Person Controller

This package contains modular, first person controller with basic capabilities (character movement, camera aiming, gravity & basic jumping), that is easily modifiable to your needs.

The Input Actions are currently rigged to work with Keyboard/Mouse and Gamepads.

## How to expand upon it

The idea is to create what I call **Movement Modifiers** by creating classes that inherit from the correspondigly named `MovementModifier` class. This class in turn implements a very simple interface, `IMovementModifier`. A list of enabled Movement Modifiers is kept by the `MovementHandler` class, which adds up all of the values for the Movement Modifiers and excecutes them through the Character Controller Component.

## Dependencies

### Hard Dependencies

These are a must for this package to work properly:

- [Input System: ^1.0.2](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/manual/QuickStartGuide.html)

### Soft Dependencies

These are nice to have but the package can work without them with minimal changes:

- [Cinemachine: ^2.7.4](https://docs.unity3d.com/Packages/com.unity.cinemachine@2.7/manual/index.html)
