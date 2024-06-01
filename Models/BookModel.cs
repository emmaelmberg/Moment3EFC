using System.ComponentModel.DataAnnotations;
namespace Moment3EFC.Models;

public class BookModel {
    public int ID { get; set; }

    [Required]
    public string? Name { get; set; }

    public string? Description { get; set;}

    [Display(Name = "Choose an author")]
    public int? AuthorID { get; set; }
    public AuthorModel? Author { get; set; }
}