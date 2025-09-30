namespace SisGT.Models
{
    public class TaskModel
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; } = false;
    }
}
