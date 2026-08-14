namespace AssignmentManagement.Domain.Entities;

public class StudentClass
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int ClassId { get; set; }

    public User Student { get; set; } = null!;

    public Class Class { get; set; } = null!;
}