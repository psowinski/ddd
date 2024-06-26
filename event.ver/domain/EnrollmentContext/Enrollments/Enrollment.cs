using Domain.Common;
using EnrollmentContext.Courses;
using EnrollmentContext.Students;

namespace EnrollmentContext.Enrollments;

public record EnrollmentId(Guid Value);

public record Enrollment(
   EnrollmentId Id,
   SeqNum SequenceNumber,
   StudentId StudentId,
   CourseId CourseId,
   bool Enrolled)
   : Entity<EnrollmentId>(Id, SequenceNumber);
