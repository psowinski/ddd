using Domain.Common;
using EnrollmentContext.Courses;
using EnrollmentContext.Students;

namespace EnrollmentContext.Enrollments.UnenrollStudent;

public record StudentNotOnCourse(StudentId Student, CourseId Course) : Error;
