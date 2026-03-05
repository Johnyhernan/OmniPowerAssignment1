# OmniPower Assignment 1

## Option Chosen

Option B was selected due to prior experience with C#, .NET, and the Visual Studio IDE.

---

## Prerequisites

- Visual Studio 2022 or later
- .NET 8.0

---

## Setup

### 1. Clone the Repository

**Using Visual Studio:**

Go to **Git > Clone Repository** and paste the following into the Repository Location field:
```
https://github.com/Johnyhernan/OmniPowerAssignment1
```

**Using Git Bash:**
```
git clone https://github.com/Johnyhernan/OmniPowerAssignment1
```

### 2. Open the Project

1. Go to **File > Open > Project/Solution**
2. Select `OmniPowerAssignment.csproj`
3. Build the solution, then run

---

## How to Use

The GUI displays live monitoring data for three sensors: **Temperature**, **Humidity**, and **Pressure**.


 **Start**  Toggles data gathering on/off for all sensors 
 
 **Threshold Textbox**  Sets a numeric threshold. If the following checkbox is enabled a warning will appear if current value in graph exceeds threshold. Non-numeric input triggers a validation warning textbox.
 
 **Chart**  Displays a continuously updating value-vs-time graph for the sensor chosen in the dropdown. When the gui first starts temp-vs-time is chosen automatically.

---

## Important Classes

### `Sensor`
Represents a single sensor object.


**NameOfSensor**  Specifies the sensor type 
**Units**  Specifies the unit of measurement 
**RangeOf**  Defines the range used for data generation 

### `Sensor_Handler`
Manages all sensor data and acts as the intermediary between the UI and sensor data, following the **MVVM** design pattern. Uses queues to track the latest values while automatically discarding the oldest entries.

## Architecture
    |Sensor| <-> |Sensor_Handler| <-> |UI|
  ## ToDo
    Add CSV Function

  







