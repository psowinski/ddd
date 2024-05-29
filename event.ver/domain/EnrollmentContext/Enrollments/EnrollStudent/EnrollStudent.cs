using Domain.Common;
using EnrollmentContext.Courses;
using EnrollmentContext.Students;
using OneOf;

namespace EnrollmentContext.Enrollments.EnrollStudent;

public record EnrollStudent(CorellationId CorellationId, StudentId Student, Course Course, uint CountStudentsOnCourse) : Command
{
   public OneOf<StudentEnrolled, Error> Execute(Enrollment enrollment)
   {
      if (enrollment.Enrolled)
         return new StudenAlreadyEnrolled(Student, Course.Id);

      if (Course.StudentsLimit.HasValue && CountStudentsOnCourse >= Course.StudentsLimit)
         return new EnrollmentLimitReached(Student, Course);

      return new StudentEnrolled(
         EventId.NewId(), enrollment.Id, enrollment.SequenceNumber.Inc(), CorellationId,
         Student, Course.Id);
   }
}
