# Rovy Week 4 — Challenge Labs

**Module:** 4 | **MSSA CAD Cohort** | **Language:** C#

---

## Overview

A C# console application built as part of the MSSA Week 4 Challenge Labs curriculum. This project implements three algorithm-focused challenges in a single menu-driven app, demonstrating digit manipulation, divisibility logic, and in-place array reversal using a two-pointer technique.

---

## Features

- **IfNumberContains3** — Determines whether a given integer contains the digit 3 by repeatedly extracting digits using `%` and `/` operators
- **DivisibleBy2Or3** — Takes two numbers and multiplies them if both are divisible by 2 and 3, sums them if only one condition is met, or reports neither
- **Reverse String In-Place** — Converts a string to a `char[]` and reverses it using a two-pointer swap without allocating a second array
- Menu-driven interface that loops until the user exits
- Input validation with graceful error handling on all numeric inputs

---

## How to Run

1. Clone the repo or download `Program.cs`
2. Open Visual Studio and create a new **Console App (.NET)** project
3. Replace the default `Program.cs` with the one from this repo
4. Press `F5` or `Ctrl + F5` to run

---

## Key Concepts

- **Digit Extraction** — Using `% 10` to check last digit and `/= 10` to peel digits off an integer
- **Modulus & Divisibility** — `%` operator to evaluate divisibility conditions on two numbers
- **Two-Pointer Technique** — In-place char array reversal with O(n) time and O(1) space
- **Input Validation** — `int.TryParse` to handle bad user input gracefully
- **String ↔ Char Array** — `ToCharArray()` and `new string(chars)` conversions
- **Algorithm Thinking** — Breaking problems into digit-level and pointer-level operations

---

## Tech Stack

![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat&logo=dotnet&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=flat&logo=visualstudio&logoColor=white)

---

## Author

**Bobby Rovy** | U.S. Army Veteran | MSSA CAD Program  
[GitHub Profile](https://github.com/brovy23-GD)
