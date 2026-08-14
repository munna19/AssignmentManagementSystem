using AssignmentManagement.Domain.Enums;

namespace AssignmentManagement.Domain.Entities;

public class Assignment
{
    public int Id { get; set; }

    public int TeacherId { get; set; }

    public int ClassId { get; set; }

    public int SubjectId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime Deadline { get; set; }

    public decimal MaxMarks { get; set; }

    public AssignmentStatus Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public User Teacher { get; set; } = null!;

    public Class Class { get; set; } = null!;

    public Subject Subject { get; set; } = null!;

    public ICollection<Submission> Submissions { get; set; }
        = new List<Submission>();
}