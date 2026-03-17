# Unity Event Architecture

A lightweight **ScriptableObject-based event system** for Unity.

This project demonstrates a simple and decoupled **event-driven architecture** that allows different GameObjects to communicate without direct references.

The goal of this project is to showcase a **clean and modular Unity event system** suitable for small and mid-size gameplay systems.

---

# Features

- ScriptableObject Event Channels
- Decoupled communication between systems
- Multiple listeners per event
- Custom Inspector for debugging
- Modular responder examples
- Clean project structure
- Demo scene included

---

# Architecture Overview

The system follows a simple event flow:

Invoker
↓
EventChannel (ScriptableObject)
↓
Listeners
↓
Responses


Objects do not directly reference each other.

Instead, they communicate through **event channels**.

---

# Core Components

## Event Channel

`VoidEventChannelSO`

ScriptableObject that broadcasts events to registered listeners.

Responsibilities:
- Register listeners
- Unregister listeners
- Raise events

---

## Event Listener

`VoidEventListener`

Subscribes to an Event Channel and invokes UnityEvents when the event is raised.

Responsibilities:
- Subscribe on enable
- Unsubscribe on disable
- Execute responses

---

## Event Invoker

`VoidEventInvoker`

Raises an event on a specific Event Channel.

Typically triggered by UI buttons or gameplay systems.

---

# Example Responders

These components demonstrate how listeners can react to events.

### DebugLogResponder
Prints a message to the Console.

### GameObjectToggleResponder
Toggles the active state of a GameObject.

### SetActiveResponder
Sets a GameObject active or inactive.

---

# Demo Scene

The demo scene contains three event flows:

### Debug Log Event

Button → Event → DebugLogResponder


### Toggle Cube Event

Button → Event → ToggleCubeResponder → Cube toggles visibility


### Show Panel Event

Button → Event → SetActiveResponder → UI Panel appears


---

# Folder Structure


Assets/_Project
│
├── Scripts
│ ├── Runtime
│ │ ├── Events
│ │ ├── Listeners
│ │ └── Examples
│ │
│ └── Editor
│
└── ScriptableObjects


---

# Purpose of This Project

This repository was created as a **portfolio project** to demonstrate:

- Unity architecture skills
- clean and modular code
- event-driven design
- ScriptableObject-based systems

---

# Future Improvements

Possible extensions:

- Generic Event Channels
- Typed Events (int, float, bool, Vector3)
- Debug tooling
- Event history tracking

---

# Author

Created by **Bora Cingöz**

Unity Developer