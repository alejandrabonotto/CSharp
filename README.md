## Overview
This repository contains lines of code that I've written during my C# studies.

## Running the Programs
To run the programs, follow these steps:

1. Open the project in your preferred C# development environment (Visual Studio, Visual Studio Code, etc.).
2. Compile and execute the main.cs file.
3. Follow any on-screen prompts or instructions.

# APPLICATIONS

## Basics Concepts

__*HR Application Folder*__
It is an HR application designed to perform the following tasks:

1. Main Menu: Users can select to add an employee, display employee information, or exit.
2. Add Employee Menu: Users can select the type of employee to add – commission employee, salaried employee, or hourly employee – or they can return to the Main Menu.
2.1. Commission Employee: Users provide the employee’s ID, name, total sales, and percentage of commission. The application then displays the total earnings.
2.2. Salaried Employee: Users provide the employee’s ID, name, and salary. There are three bonuses for this category. The application shows the total earnings according to the assigned bonus.
2.3. Hourly Employee: Users provide the employee’s ID, name, hourly rate, and total weekly hours worked. The application shows total earnings, considering any extra hours worked.
3. Display Employee Menu: Users can choose to display information for all employees, display information for a specific employee by ID, or return to the Main Menu.

This application demonstrates knowledge of basic concepts of C#, such as user inputs, if and else statements, switch statements, loops, break and return, arrays, and methods.

## Intermediate Concepts

__*Student Class 01**__
It is a simple code that shows the concept of a class and objects, properties and its getters and setters, and how to display the data implicitly and explicitly.

The program created allows to initiate an object through the constructor or the setters; the object instantiated from the constructor is displayed through the override ToString() method; then, this object is modified through the setters and displayed through the DisplayInfo() method.

__*Student Class 02**__
It is a simple code that shows the concept of an abstract class and how to inherit from it. 
A class that is not able to be instantiated is called abstract. Rather, it acts as a basic class from which other classes might be derived. To provide a common set of attributes or behaviors that derived classes ought to possess, abstract classes are utilized. An abstract class cannot have objects created for it; instead, a derived class must be created from it. in order to use the derived class's object to access members of the abstract class.

 The program has an abstract class called Student with an abstract study() method. From this abstract class two classes were inherited, regular Student and fast track Student; and the method study() was overridden in both inherited classes 

__*Time Sum **__
It is a simple code that shows the concept of operator overloading. Using the same operator for several tasks is made possible by operator overloading. As it is applied to user-defined data types, it gives C# operators more powers. It permits the creation of user-defined implementations for a variety of operations in which one or both operands belong to a user-defined class. 

The program created allows to add time. The class Time can initiate object with the attributes of hours, minutes and second. The operator overloading method allows the sum of time, adjusting the excess of seconds to minutes and the excess of minutes to hours. 











