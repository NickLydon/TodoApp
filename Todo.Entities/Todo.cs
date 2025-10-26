using System.ComponentModel.DataAnnotations;

namespace TodoEntities;

public class Todo
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = default!;
    public bool IsComplete { get; set; }

    [Required]
    public string OwnerId { get; set; } = default!;
}

// The DTO that excludes the OwnerId (we don't want that exposed to clients)
