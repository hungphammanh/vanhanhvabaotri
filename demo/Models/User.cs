using System.ComponentModel.DataAnnotations;

namespace demo.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
		[Required(ErrorMessage = "Vui lòng nhập tên.")]
		public string? Name { get; set; }
		[Required(ErrorMessage = "Vui lòng nhập email.")]
		[EmailAddress(ErrorMessage = "Vui lòng nhập địa chỉ email hợp lệ.")]
		public string? Email { get; set; }
		[Required(ErrorMessage = "Vui lòng nhập mật khẩu.")]
		public string? Password { get; set; }
        public String? Role { get; set; }

    }
}
