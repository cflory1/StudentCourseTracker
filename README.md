# Student Course Tracker

A full-stack web application for managing student enrollment records, built with ASP.NET Core MVC and Entity Framework Core.

## Overview

Student Course Tracker allows administrators to manage students, courses, and enrollments through a clean, intuitive interface. Built to demonstrate real-world database relationships and CRUD operations using modern .NET technologies.

## Features

- **Student Management** — Add, view, edit, and delete student records with first name, last name, email, enrollment date, and status
- **Course Management** — Manage a course catalog with course name, instructor, and credit hours
- **Enrollment Management** — Enroll students in courses, track enrollment dates, and update grades as courses are completed
- **Relational Data** — Students and courses are linked through an enrollments table, reflecting real-world database design
- **Dropdown Menus** — Status and grade fields use dropdowns to enforce consistent data entry
- **Clean UI** — Striped tables, color-coded buttons, and styled headers for a professional look

## Tech Stack

- **Framework:** ASP.NET Core MVC (.NET 8)
- **ORM:** Entity Framework Core (Code First)
- **Database:** SQL Server (LocalDB)
- **Frontend:** Razor Views, Bootstrap
- **Language:** C#

## Database Structure

Three related tables managed by Entity Framework:

| Table | Key Fields |
|-------|-----------|
| Students | Id, FirstName, LastName, Email, EnrollmentDate, Status |
| Courses | Id, CourseName, Instructor, Credits |
| Enrollments | Id, StudentId, CourseId, DateEnrolled, Grade |

## Getting Started

### Prerequisites
- Visual Studio 2022
- .NET 8 SDK
- SQL Server LocalDB (included with Visual Studio)

### Setup
1. Clone the repository
2. Open `StudentCourseTracker.sln` in Visual Studio
3. Open Package Manager Console and run:
   ```
   Update-Database
   ```
4. Press F5 to run the application

The app will open directly to the Students page.

## What I Learned

- ASP.NET Core MVC project structure and routing
- Entity Framework Code First migrations and database management
- Model relationships (one-to-many, many-to-many via junction table)
- Preventing overposting attacks using Bind attributes
- Razor view syntax and tag helpers
- Bootstrap styling within MVC views
