using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeShopRegistration.Models;

public class User
{
    public int Id { get; set; }
    
    //attributes some people say annotations
    [Column(TypeName = "varchar(50)")]
    [Required]
   
 
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [EmailAddress]
    [Required]
    public string Email { get; set; }
}