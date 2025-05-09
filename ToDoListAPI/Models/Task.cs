// Models/Task.cs
using System.Collections.Generic;

namespace TodoApi.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public List<Comment> Comments { get; set; } = new();
    }
}