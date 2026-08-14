namespace AssignmentManagement.Domain.Entities;

public class TeacherAssignment
{
    public int Id { get; set; }

    public int TeacherId { get; set; }

    public int ClassId { get; set; }

    public int SubjectId { get; set; }

    public User Teacher { get; set; } = null!;

    public Class Class { get; set; } = null!;

    public Subject Subject { get; set; } = null!;
}