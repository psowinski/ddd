using Domain.Common;
using OneOf;

namespace EnrollmentContext.Courses.StudentsLimit;

public record SetStudentsLimit(uint? StudentsLimit) : Command
{
   public Course Execute(Course course)
   {
      return course with
      {
         StudentsLimit = StudentsLimit
      };
   }      
}
