using Domain.Common;
using EnrollmentContext.Courses;
using EnrollmentContext.Students;
using OneOf;

namespace EnrollmentContext.Enrollments.UnenrollStudent;
public record UnenrollStudent(CorellationId CorellationId, StudentId Student, CourseId Course) : Command
{
   public OneOf<StudentUnenrolled, Error> Execute(Enrollment enrollment)
   {
      if (!enrollment.Enrolled)
         return new StudentNotOnCourse(Student, Course);

      return new StudentUnenrolled(
         EventId.NewId(), enrollment.Id, enrollment.SequenceNumber.Inc(), CorellationId,
         Student, Course.Id);
   }
}

