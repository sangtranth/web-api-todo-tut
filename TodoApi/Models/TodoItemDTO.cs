using System;
namespace TodoApi.Models
{
    public class TodoItemDTO
    {
        public TodoItemDTO()
        {

        }

        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
