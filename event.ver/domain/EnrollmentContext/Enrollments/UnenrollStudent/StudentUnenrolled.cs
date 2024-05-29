using Domain.Common;
using EnrollmentContext.Courses;
using EnrollmentContext.Students;
using OneOf;

namespace EnrollmentContext.Enrollments.UnenrollStudent;

public record StudentUnenrolled(
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
            Enrolled = false
         });
   }
}
