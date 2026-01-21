# C# Generic CustomList<T> Practice

This repository contains a C# console application that demonstrates the implementation
of a generic `CustomList<T>` class with common collection operations. It also includes
OOP concepts and exception handling using a `Human` class with age validation.

## Features

- Generic `CustomList<T>` supporting:
  - `Add(T item)`
  - `Remove(T item)`
  - `Contains(T item)`
  - `Count()`
  - `Clear()`
  - `PrintAll()`
- `Human` class with:
  - Properties: `Name`, `Surname`, `Age`
  - Age validation with custom `AgeException`
- Demonstrates usage with both `int` and `Human` types

## Example Usage

```csharp
CustomList<int> numbers = new CustomList<int>();
numbers.Add(5000);
numbers.Add(150);
numbers.PrintAll();
numbers.Remove(150);

Human h1 = new Human("Ali", "Aliyev", 25);
CustomList<Human> humans = new CustomList<Human>();
humans.Add(h1);
humans.PrintAll();
