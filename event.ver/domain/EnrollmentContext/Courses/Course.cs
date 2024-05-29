using Domain.Common;

namespace EnrollmentContext.Courses;

public record CourseId(Guid Value);

public record Course(CourseId Id, SeqNum SequenceNumber, uint? StudentsLimit)
   : Entity<CourseId>(Id, SequenceNumber);
