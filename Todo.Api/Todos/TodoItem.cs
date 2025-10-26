using System.ComponentModel.DataAnnotations;

namespace TodoApi;

public class TodoItem
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = default!;
    public bool IsComplete { get; set; }
}
