using System;

namespace ToDoApp.Core.Entities
{
    public class Todo
    {
        public int Id { get; set; }
        public int? UserId { get; set; } //? işaret boş geçilebilir olduğunu belirtir
        public int? PriorityId { get; set; }
        public int TodoStatusId { get; set; }
        public string Title { get; set; } //String de ? işareti koyamazsın !!!
        public string Description { get; set; }
        public DateTime EndDate { get; set; }
    }
}
