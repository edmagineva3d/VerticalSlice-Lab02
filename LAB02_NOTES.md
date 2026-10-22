
## Lab overview

This lab follows the instructor guide for tracing a request and reading admissions.

## Original template

The starting project is the uploaded VerticalSlice-Edma template with Api, Application, Domain and Infrastructure.

## Request path

The HTTP request enters Api, calls the Application handler, uses the Infrastructure database context, and reads Domain entities.

## Debugger setup

Open VerticalSlice.slnx, select Api as the startup project, and launch the debugger with F5.

## Breakpoint A

Set a breakpoint inside the Create method of Api/Features/Admissions/AdmissionEndpoints.cs.
