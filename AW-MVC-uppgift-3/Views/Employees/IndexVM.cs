using System.ComponentModel.DataAnnotations;


namespace AW_MVC_uppgift_3.Views.Employees
{
	public class IndexVM
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		
		public bool ShowAsHighlighted { get; set; } 
	}
}
