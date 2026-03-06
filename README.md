# C# 14 & .NET 10 Fundamentals: Console Banking App 🏦

This repository contains Phase 1 of my comprehensive C# and .NET 10 learning journey. It is a fully functional, interactive console-based banking application designed to demonstrate mastery of core C# syntax, logic, and Object-Oriented Programming (OOP) principles.

## 🚀 Features
* **Interactive Command-Line UI:** A continuous `while` loop menu that accepts user input and gracefully handles invalid data types using defensive programming (`TryParse`).
* **Transaction Processing:** Users can withdraw funds, with the system strictly enforcing balance limits to prevent overdrafts.
* **Transaction History:** A chronological ledger of all deposits and withdrawals.
* **Deposit Reporting:** Dynamically calculates and displays only the user's deposits and their total sum using Language Integrated Query (LINQ).

## 🧠 Core Concepts Mastered
This project was built without relying on external libraries, focusing entirely on native C# 14 capabilities:
* **Modern Syntax:** Top-level statements, string interpolation, and implicit collection expressions `[]`.
* **Data Types & Variables:** Strict use of `decimal` for financial accuracy to prevent floating-point errors.
* **Control Flow:** Complex `if/else` logic and `switch` statements for menu navigation.
* **Object-Oriented Programming (OOP):** * Extracted logic into a dedicated `BankAccount` class.
  * **Encapsulation:** Protected the `_transactionHistory` list using the `private` and `readonly` modifiers to prevent accidental data overwrites from outside the class.
* **LINQ (Language Integrated Query):** Utilized `.Where()` and `.Sum()` with Lambda expressions (`=>`) to filter and aggregate transaction data efficiently.