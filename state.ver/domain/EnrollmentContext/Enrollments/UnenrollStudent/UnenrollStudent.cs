using Domain.Common;
using EnrollmentContext.Courses;
using EnrollmentContext.Students;
using OneOf;

namespace EnrollmentContext.Enrollments.UnenrollStudent;
public record UnenrollStudent(StudentId Student, CourseId Course) : Command
{
   public OneOf<Enrollment, Error> Execute(Enrollment enrollment)
   {
      if (!enrollment.Enrolled)
         return new StudentNotOnCourse(Student, Course);

      return enrollment with
      {
         Enrolled = false
      };
   }
}

