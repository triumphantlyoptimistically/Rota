# Rota Scheduling System

A simple employee scheduling system written in C# (.NET Framework 4.7.2).  
This project demonstrates object-oriented programming principles for managing employee availability, shift assignments, and conflict detection in a workplace scheduling scenario.

## Features

- **Employee Management:** Store employees with positions and recurring weekly availability.
- **Shift Creation:** Create shifts with specific dates, times, and position requirements.
- **Availability Checking:** Automatically validate if an employee can work a shift based on position, day, and time.
- **Double-Booking Prevention:** Detects scheduling conflicts to prevent assigning employees to overlapping shifts.
- **Unfilled Shift Detection:** Quickly identify shifts that still need coverage.
- **Available Employee Lookup:** Find all eligible employees for a specific shift.

## Project Structure

- `Rota/Employee.cs` – Employee class with nested Availability struct.
- `Rota/Shift.cs` – Shift class with flexible constructors for filled/unfilled shifts.
- `Rota/Scheduler.cs` – Core scheduling logic for assignments and conflict detection.
- `Rota/Program.cs` – Entry point and example usage.

## Getting Started

1. **Clone the repository:** git clone https://github.com/triumphantlyoptimistically/Rota.git
2. **Open the solution in Visual Studio 2026** (or compatible version).
3. **Build and run the project.**
4. **Modify `Program.cs` to create your own employees and shifts.**

## Requirements

- .NET Framework 4.7.2
- Visual Studio 2026 or later (or any compatible C# IDE)

## How It Works

1. **Employee Setup:** Create employees with recurring weekly availability using `DayOfWeek` and `TimeSpan`.
2. **Shift Creation:** Define shifts with specific dates and times using `DateTime`.
3. **Availability Checking:** The scheduler compares shift times against employeeavailability, checking position match, day match, and time range.
4. **Conflict Detection:** Nested loops detect overlapping shifts to prevent double-booking.
5. **Assignment:** Valid assignments update the shift's `EmployeeOnShift` property.
