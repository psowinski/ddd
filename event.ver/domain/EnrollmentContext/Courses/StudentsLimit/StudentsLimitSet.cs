using Domain.Common;
using OneOf;

namespace EnrollmentContext.Courses.StudentsLimit;

public record StudentsLimitSet(
   EventId EventId,
   CourseId EntityId,
   SeqNum SequenceNumber,
   CorellationId CorellationId,
   uint? StudentsLimit) : Event<CourseId>
{
   public OneOf<Course, Error> Apply(Course course)
   {
      return this.ApplyValidEvent(course)
         .MapT0(_ => course with
         {
            SequenceNumber = SequenceNumber,
            StudentsLimit = StudentsLimit
         });
   }
}
