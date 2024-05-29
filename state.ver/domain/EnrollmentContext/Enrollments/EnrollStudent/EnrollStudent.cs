using Domain.Common;
using EnrollmentContext.Courses;
using EnrollmentContext.Students;
using OneOf;

namespace EnrollmentContext.Enrollments.EnrollStudent;

public record EnrollStudent(StudentId Student, Course Course, uint CountStudentsOnCourse)
{
   public OneOf<Enrollment, Error> Execute(Enrollment enrollment)
   {
      if (enrollment.Enrolled)
         return new StudenAlreadyEnrolled(Student, Course.Id);

      if (Course.StudentsLimit.HasValue && CountStudentsOnCourse >= Course.StudentsLimit)
         return new EnrollmentLimitReached(Student, Course);

      return enrollment with
      {
         Enrolled = true
      };
   }
}
