# Sogeti - Microsoft Assessment

Welcome to the C# assessment for the Microsoft Community at Sogeti. In this solution you are presented with four challenges to solve.
It is here to give us an insight in your level of knowledge and experience.
The time to use on this assessment should be about 2 to 3 hours.

NOTE: Changing or removing of unit tests is not allowed, these are there to validate the implementation. You are of course free to add tests at will.

## Requirements

- All code is written in .Net 6, this is required to build and run the code.
- IDE:
  - Windows: Visual Studio 2022 Community Edition.
  - Mac: Visual Studio 2019.
  - Any platform: Visual Studio Code.
- Build:
  - From Visual Studio directly.
  - From the command line (cmd/powershell/bash) using `dotnet build`.
- Test:
  - Run the unit tests using Test Explorer in Visual Studio.
  - From the command line (cmd/powershell/bash) using `dotnet test`.

## 1. Parentheses Balancing

Calculates if the parenthesis of the input string are correctly balanced. The unit tests should provide some specific details on the valid scenarios.

## 2. Publisher/Subscriber

Write a Publisher class that publishes two events: Started and Completed. Both events must include an informational message.

Write a Subscriber class that subscribes to the events of the Publisher and writes the received informational messages to the console.

## 3. CharReverse

Implement the method in CharReverse.cs to Reverse the characters in each word in the sentence, while keeping the same order of words.
The words are delimited by: space, comma, dot. For example: `The quick brown fox` ==> `ehT kciuq nworb xof`

## 4. Refactor Geometrical Shapes

Refactor the Shape class to respect object orientation principles. 

- Imagine the code changes that need to be made when new shapes need to be supported, change the code to make it easy to add shapes
- Imagine the code changes that need to be made when a new language like French needs to be supported, change the code to make it easy to add languages
- **Feel free to update the tests to work for your code, respecting the scenario that's tested**.
