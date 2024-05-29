using Domain.Common;
using EnrollmentContext.Courses;
using EnrollmentContext.Students;

namespace EnrollmentContext.Enrollments.EnrollStudent;

public record StudenAlreadyEnrolled(StudentId Student, CourseId Course) : Error;
