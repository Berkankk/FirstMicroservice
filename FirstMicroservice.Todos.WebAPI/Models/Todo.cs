namespace FirstMicroservice.Todos.WebAPI.Models
{
    public class Todo
    {
        public int ID { get; set; }
        public string Work { get; set; } = default!;
    }
}
