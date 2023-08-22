using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace aspsql.Models
{
    public class UsersModel
    {
        [Display(Name="Возраст")]
        [Range(7,70,ErrorMessage ="Вы не попадаете под требования возраста")]
        public int age { get; set; }

       
        [Display(Name = "Имя")]
        [Required(ErrorMessage ="Необходимо ввести имя")]
        public string name { get; set; }

        
        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Необходимо ввести фамилию")]
        public string surname { get; set; }

        
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Необходимо ввести Email")]
        public string Email { get; set; }

        
        [Display(Name = "Подтверждение Email")]
        [DataType(DataType.EmailAddress)]
        [Compare("Email", ErrorMessage ="Email не совпадают")]
        public string ConfirmEmail { get; set; }

        
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Необходимо ввести Пароль")]
        [StringLength(50,MinimumLength =4,ErrorMessage ="Пароль должен быть больше 4 символов")]
        public string Password { get; set; }

        [Display(Name = "Подтвердите Пароль")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password не совпадают")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Пароль должен быть больше 4 символов")]
        public string ConfirmPassword { get; set; }
    }
}