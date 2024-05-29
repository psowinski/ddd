using Domain.Common;
using EnrollmentContext.Courses;
using EnrollmentContext.Students;
using OneOf;

namespace EnrollmentContext.Enrollments.UnenrollStudent;
public record UnenrollStudent(CorellationId CorellationId, StudentId Student, Course Course) : Command
{
   public OneOf<StudentUnenrolled, Error> Execute(Enrollment enrollment)
   {
      if (!enrollment.Enrolled)
         return new StudentNotOnCourse(Student, Course.Id);

      return new StudentUnenrolled(
         EventId.NewId(), enrollment.Id, Course.SequenceNumber.Inc(), CorellationId,
         Student, Course.Id);
   }
}

