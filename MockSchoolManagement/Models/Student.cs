using MockSchoolManagement.Models.EnumTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MockSchoolManagement.Models
{
    public class Student
    {
        private int id;
        private string name;
        private MajorEnum? major;
        private string email;

        public int Id { get => id; set => id = value; }
        [Display(Name="名字")]
        [Required(ErrorMessage ="请输入名字，它不能为空"),MaxLength(50,ErrorMessage ="名字的长度不能超过50个字符")]
        public string Name { get => name; set => name = value; }
        [Display(Name = "主修科目")]
        [Required(ErrorMessage ="请选择一门科目")]
        public MajorEnum? Major { get => major; set => major = value; }

        [Display(Name = "电子邮件")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
       ErrorMessage = "邮箱的格式不正确")]
        [Required(ErrorMessage = "请输入邮箱地址,它不能为空")]
        public string Email { get => email; set => email = value; }

    }
}
