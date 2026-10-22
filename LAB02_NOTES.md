
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

## Breakpoint B

Set a breakpoint at the beginning of CreateAdmissionCommandHandler.HandleAsync.

## Breakpoint C

Pause at dbContext.Admissions.Add(admission) and inspect admission.Id and admission.AdmissionCourses.Count.

## Breakpoint D

Pause after SaveChangesAsync and inspect admission.Id again.

## Student lookup

Use GET /api/students in Scalar to copy a valid student GUID.
