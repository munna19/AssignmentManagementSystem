namespace AssignmentManagement.Domain.Entities;

public class Subject
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Code { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public ICollection<TeacherAssignment> TeacherAssignments { get; set; }
        = new List<TeacherAssignment>();

    public ICollection<Assignment> Assignments { get; set; }
        = new List<Assignment>();
}