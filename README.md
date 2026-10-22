# Lab 02 – Trace a Request and Add an Endpoint

## Overview

This project is part of our laboratory activities in API Backend Development. In this activity, I learned how an HTTP request moves through the different layers of a Vertical Slice Architecture and how to create a new API endpoint.

The main purpose of Lab 02 is to trace an admission request using breakpoints, understand how data is saved to the database, and implement a new `GET /api/admissions` endpoint.

This project uses the original Vertical Slice Architecture template provided by our instructor, **Elvin Manuel R. Luces, MIT**.

## Technologies Used

- C# and .NET
- ASP.NET Core Web API
- Entity Framework Core
- Vertical Slice Architecture
- Scalar API Documentation
- Visual Studio / Visual Studio Code
- Git and GitHub

## Project Structure

The project follows four main layers:

1. **Api** – Handles HTTP requests, API endpoints, and responses.
2. **Application** – Contains commands, queries, handlers, and application logic.
3. **Domain** – Contains entities and common result classes.
4. **Infrastructure** – Handles database operations and data access.

## Features and Activities

1. Traced an HTTP request through the different project layers.
2. Set four breakpoints to observe the admission creation process.
3. Used the debugger's Watch window to inspect variables.
4. Checked the admission ID before saving to the database.
5. Observed how the admission ID changes after saving.
6. Created the `GetAllAdmissionsQuery` and response records.
7. Implemented the `GetAllAdmissionsQueryHandler`.
8. Added the `GET /api/admissions` endpoint.
9. Registered the new query handler using dependency injection.
10. Tested the new endpoint using Scalar.
11. Checked the returned student name and course count.
12. Learned how queries and handlers work in Vertical Slice Architecture.

## API Endpoint

### GET /api/admissions

This endpoint retrieves the list of admissions stored in the database.

Each admission contains:

- Admission ID
- Student ID
- Student Name
- Academic Year
- Admission Date
- Course Count

## How to Run the Project

**1. Restore the project dependencies**

```bash
dotnet restore
```

**2. Build the project**

```bash
dotnet build
```

**3. Run the API**

```bash
dotnet run --project Api
```

**4. Open Scalar API Documentation**

Open the following URL in your browser:

```text
http://localhost:5205/scalar/v1
```

**5. Test the endpoint**

```http
GET /api/admissions
```

The endpoint should return a list of admissions with the student information and number of enrolled courses.

## What I Learned

In this activity, I learned how to trace an API request using breakpoints and understand what happens before and after saving data to the database.

I also learned how to create a query, handler, and endpoint in their correct project layers. This helped me understand how Vertical Slice Architecture organizes API features and how dependency injection connects the different parts of the application.

## Credits and Acknowledgment

The original Vertical Slice Architecture project template and laboratory activity guide were provided by our instructor, **Elvin Manuel R. Luces, MIT**, from **Computer Communication Development Institute (CCDI) – Sorsogon Campus**.

All credits for the original project template and laboratory instructions belong to our instructor.

This project was modified and completed as part of our laboratory requirements in API Backend Development.

**Instructor:** Elvin Manuel R. Luces, MIT  
**Institution:** Computer Communication Development Institute (CCDI)  
**Campus:** Sorsogon Campus  
**Course:** API Backend Development
