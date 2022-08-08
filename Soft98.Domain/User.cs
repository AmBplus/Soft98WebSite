using System.ComponentModel.DataAnnotations;

namespace Soft98.Domain;

public class User
{
    [Key]
    public int Id { get; set; }
    public int RoleId { get; set; }
    [Display(Name = "شماره همراه")]
    [Required(ErrorMessage = "مقدار {0} را وارد کنید ")]
    [MaxLength(11,ErrorMessage = "مقدار {0} نمیتواند بیشتر از {1} باشد")]
    public string Mobile { get; set; }
    [Display(Name = "رمز عبور")]
    [MaxLength(50, ErrorMessage = "مقدار {0} نمیتواند بیشتر از {1} باشد")]
    public string Password { get; set; }
    [Display(Name = "کد فعال سازی")]
    [MaxLength(6, ErrorMessage = "مقدار {0} نمیتواند بیشتر از {1} باشد")]
    public string Code { get; set; }
    [Display(Name = "فعال/غیرفعال")]
    public bool IsActive { get; set; }
    public virtual ICollection<UserRole> UserRoles { get; set; }

}