using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Soft98.Domain;

public class Role
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "نام")]
    [Required(ErrorMessage = "مقدار {0} را وارد کنید ")]
    [MaxLength(20, ErrorMessage = "مقدار {0} نمیتواند بیشتر از {1} باشد")]
    public string Name { get; set; }
    public virtual ICollection<UserRole> UserRoles { get; set; }
}