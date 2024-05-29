using Domain.Common;
using EnrollmentContext.Courses;
using EnrollmentContext.Students;

namespace EnrollmentContext.Enrollments;

public record EnrollmentId(Guid Value);

public record Enrollment(
   EnrollmentId Id,
   StudentId StudentId,
   CourseId CourseId,
   bool Enrolled);
