using Domain.Common;
using EnrollmentContext.Courses;
using EnrollmentContext.Students;

namespace EnrollmentContext.Enrollments.EnrollStudent;

public record EnrollmentLimitReached(StudentId Student, Course Course) : Error;
