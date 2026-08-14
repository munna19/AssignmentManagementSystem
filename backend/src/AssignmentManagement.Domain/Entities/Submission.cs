using AssignmentManagement.Domain.Enums;

namespace AssignmentManagement.Domain.Entities;

public class Submission
{
    public int Id { get; set; }

    public int AssignmentId { get; set; }

    public int StudentId { get; set; }

    public string Answer { get; set; } = string.Empty;

    public DateTime SubmittedAt { get; set; }

    public SubmissionStatus Status { get; set; }

    public decimal? Marks { get; set; }

    public string? Feedback { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Assignment Assignment { get; set; } = null!;

    public User Student { get; set; } = null!;
}