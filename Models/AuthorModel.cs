using System.ComponentModel.DataAnnotations;
namespace Moment3EFC.Models;

public class AuthorModel {
    public int ID { get; set; }

    [Required]
    public string? Name { get; set; }

    public List<BookModel>? Books { get; set; }
}