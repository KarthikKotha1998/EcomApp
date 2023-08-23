using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EcomApp.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }

		[MaxLength(30)]
		[Required(ErrorMessage = "Category Name is required.")]
		[DisplayName("Category Name")]
		public string Name { get; set; }

        [DisplayName("Display Order")]
        [Required(ErrorMessage = "Display Order is required.")]
        [Range(1,100, ErrorMessage ="Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
	}
}

