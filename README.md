# SWE40006 Deployment Activity 1 – Student Grade Calculator

## Project Overview

This repository contains my Student Grade Calculator desktop application developed for SWE40006 Software Deployment and Evolution – Deployment Activity 1.

The application was developed using C# Windows Forms and deployed using the WiX Toolset.

## Application Features

- Enter student name and student ID
- Enter Assignment, Test and Final Exam marks
- Validate student information and marks
- Calculate the final weighted mark
- Display the student's grade
- Display PASS or FAIL status

## Project Structure

- `GradeCalculator` – Main C# Windows Forms application
- `GradeCalculatorLibrary` – DLL containing grade calculation logic
- `StudentValidationLibrary` – DLL containing validation logic
- `GradeCalculatorInstaller` – WiX installer project
- `GradeCalculator.sln` – Visual Studio solution

## Deployment

The WiX Toolset is used to create an MSI installer for the application. The installer deploys the main application together with the required DLL dependencies.

The application was successfully installed and tested on Windows.

## Assessment Level

Task 1.4 – High Distinction

Task 1.3 was completed by deploying the desktop application with multiple DLL dependencies. For Task 1.4, the report provides a detailed explanation of how the application can be prepared and submitted to the Microsoft Store.

## Author

Student ID: 105685114
Unit: SWE40006 Software Deployment and Evolution
