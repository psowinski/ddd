using Domain.Common;
using OneOf;

namespace EnrollmentContext.Courses.StudentsLimit;

public record SetStudentsLimit(CorellationId CorellationId, uint? StudentsLimit) : Command
{
   public OneOf<StudentsLimitSet, Error> Execute(Course course)
      => new StudentsLimitSet(EventId.NewId(), course.Id, course.SequenceNumber.Inc(), CorellationId,
      StudentsLimit);
}
