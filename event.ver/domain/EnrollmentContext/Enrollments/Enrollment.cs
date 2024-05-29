using Domain.Common;
using EnrollmentContext.Courses;
using EnrollmentContext.Students;

namespace EnrollmentContext.Enrollments;

public record EnrollmentId(Guid Value);

//Enrollment entity is relation many to many and it is loaded only parialy
//For each pair student, course we load if it exist: enrolled,
//and we load actual number of studends on course
public record Enrollment(
   EnrollmentId Id,
   SeqNum SequenceNumber,
   StudentId StudentId,
   CourseId CourseId,
   bool Enrolled)
   : Entity<EnrollmentId>(Id, SequenceNumber);
