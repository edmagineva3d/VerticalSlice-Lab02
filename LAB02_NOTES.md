
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

## Course lookup

Use GET /api/courses to copy two different course GUIDs.

## Create admission

Send POST /api/admissions with studentId, academicYear and two courseIds.

## Watch expression one

Watch dbContext.GetType().Name to identify the runtime AppDbContext implementation.

## Watch expression two

Watch admission.Id before and after saving the admission.

## Watch expression three

Watch admission.AdmissionCourses.Count to confirm both selected courses are included.

## Query record

GetAllAdmissionsQuery lives in Application/Features/Admissions/GetAllAdmissions and represents a read operation.

## Response model

The admission summary includes Id, StudentId, StudentName, AcademicYear, AdmissionDate and CourseCount.

## Query handler

GetAllAdmissionsQueryHandler uses IAppDbContext to read and project admissions.

## Endpoint mapping

GET /api/admissions is mapped in Api/Features/Admissions/AdmissionEndpoints.cs.

## Dependency injection

Api/Program.cs registers the GetAllAdmissionsQueryHandler for the matching query handler interface.

## Scalar test

Run dotnet run --project Api, open /scalar/v1, and send GET /api/admissions.

## Expected response

The admissions array should contain studentName and courseCount for saved admissions.

## Missing registration test

Temporarily comment out the registration and restart to observe the dependency injection error; restore the line afterward.

## Restore registration

Keep the registration enabled in the final submission so the endpoint runs normally.

## README check

Check that the README lists GET /api/admissions alongside the existing admission routes.

## Screenshot 1

Capture the command already bound at breakpoint A with AcademicYear visible.

## Screenshot 2

Capture admission.Id as the empty GUID before saving at breakpoint C.

## Screenshot 3

Capture the assigned admission.Id after saving at breakpoint D.

## Screenshot 4

Capture the GET /api/admissions Scalar response with studentName and courseCount.
