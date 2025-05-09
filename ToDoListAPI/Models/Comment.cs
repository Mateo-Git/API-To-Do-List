// Models/Comment.cs
namespace TodoApi.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsUpdated { get; set; }
        public int TaskId { get; set; }
    }
}
