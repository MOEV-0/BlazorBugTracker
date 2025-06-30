using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorBugTracker.Models
{
    public class Bug
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = "";

        [Required]
        public string Description { get; set; } = "";

        [Required]
        public string AssignedTo { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(24)")] // Store enum as string
        public BugPriority Priority { get; set; } = BugPriority.Medium;

        [Required]
        [Column(TypeName = "nvarchar(24)")] // Store enum as string
        public BugStatus Status { get; set; } = BugStatus.Open;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }

    public enum BugPriority
    {
        Low,
        Medium,
        High,
        Critical
    }

    public enum BugStatus
    {
        Open,
        InProgress,
        Resolved,
        Closed
    }
}
