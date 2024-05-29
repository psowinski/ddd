using Domain.Common;
using EnrollmentContext.Courses;
using EnrollmentContext.Students;
using OneOf;

namespace EnrollmentContext.Enrollments.EnrollStudent;

public record StudentEnrolled(
   EventId EventId,
   EnrollmentId EntityId,
   SeqNum SequenceNumber,
   CorellationId CorellationId,
   StudentId StudentId,
   CourseId CourseId) : Event<EnrollmentId>
{
   public OneOf<Enrollment, Error> Apply(Enrollment enrollment)
   {
      return this.ApplyValidEvent(enrollment)
         .MapT0(_ => enrollment with
         {
            SequenceNumber = SequenceNumber,
            Enrolled = true
         });
   }
}
