namespace ToDoApp.API.Models
{
	public class Todo
	{
		public Guid Id { get; set; }
		public string Description { get; set; }

		public DateTime CreateDate { get; set; }

		public bool IsComplited { get; set; }

		public DateTime? CompletedDate { get; set;}

	}
}
