using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Site.Model
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Hãy nhập Họ Tên")]
        [Display(Name = "Họ Tên")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Hãy nhập Số CMND")]
        [Display(Name = "Số CMND")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Hãy nhập Điện Thoại")]
        [Display(Name = "Điện Thoại")]
        public string Phone { get; set; }

        [Display(Name = "Địa Chỉ Lắp Đặt")]
        public string Address { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Hãy Chọn Dịch Vụ")]
        [Display(Name = "Chọn Dịch Vụ")]
        public string Type { get; set; }

        [Display(Name = "Chọn Modem")]
        public string ModemType { get; set; }
    }
}