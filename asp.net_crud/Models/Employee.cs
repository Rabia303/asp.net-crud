using System.ComponentModel.DataAnnotations;

namespace asp.net_crud.Models
{
	public class Employee
	{
		[Key]
		public int e_Id { get; set; }

		public string e_Name { get; set;}

		public int e_age { get; set;}

		public string e_email {  get; set;}


	}
}
