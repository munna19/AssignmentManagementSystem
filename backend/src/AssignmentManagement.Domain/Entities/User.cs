using AssignmentManagement.Domain.Enums;

namespace AssignmentManagement.Domain.Entities;

public class User
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public UserRole Role { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    // Student relationship
    public ICollection<StudentClass> StudentClasses { get; set; }
        = new List<StudentClass>();

    // Teacher relationships
    public ICollection<TeacherAssignment> TeacherAssignments { get; set; }
        = new List<TeacherAssignment>();

    public ICollection<Assignment> Assignments { get; set; }
        = new List<Assignment>();

    public ICollection<Submission> Submissions { get; set; }
        = new List<Submission>();
}